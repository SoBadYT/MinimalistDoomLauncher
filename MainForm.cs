using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace DoomLauncher
{
    public partial class MainForm : Form
    {
        private readonly string saveFile = @"\_sobad_doom_launcher.json";
        private readonly string[] validIWads = new string[] 
        { "doom.wad", "doom2.wad", "tnt.wad", "plutonia.wad", "heretic.wad", "hexen.wad" };

        private string savePath = ""; // Sick of being yelled at about nullability on Constructor exit.
        private LauncherConfig launcherConfig = new LauncherConfig(); // ^^Same here.


        public MainForm()
        {
            InitializeComponent();
            SetLoadSavePath();
            TryLoadSettings();
        }

        #region Launcher Logic
        private bool ChangeDirectory(string message, out string newDirectory)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = message;
                fbd.ShowNewFolderButton = false;
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    newDirectory = fbd.SelectedPath;
                    return true;
                }
                newDirectory = "";
                return false;
            }
        }


        private void ChangeMode(bool demoTime)
        {
            btnDemoMode.Enabled = !demoTime;
            btnDemoMode.Visible = !demoTime;
            btnPlayMode.Enabled = demoTime;
            btnPlayMode.Visible = demoTime;

            btnDemoDirectory.Enabled = demoTime;
            btnDemoDirectory.Visible = demoTime;

            lblDemo.Visible = demoTime;

            lstDemos.Enabled = demoTime;
            lstDemos.Visible = demoTime;

            pnlPlaySettings.Enabled = !demoTime;
            pnlPlaySettings.Visible = !demoTime;

            txtOptionalArgs.Enabled = !demoTime;
            txtOptionalArgs.Visible = !demoTime;
            txtOptionalDemoArgs.Enabled = demoTime;
            txtOptionalDemoArgs.Visible = demoTime;
        }


        private void ChangeSourcePort()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.CurrentDirectory;
                openFileDialog.Filter = "Source Ports (*.exe)|*.exe|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] splitPath = openFileDialog.FileName.Split('\\');
                    string executable = splitPath[splitPath.Length - 1];
                    lblSourcePort.Text = executable;
                    launcherConfig.SourceportPath = openFileDialog.FileName;
                }
            }
        }


        private bool CheckIfValidIWad(string wadName)
        {
            return Array.IndexOf(validIWads, wadName) > -1;
        }


        private void DefaultComboBoxes()
        {
            cboCompLevel.SelectedIndex = 0;
            cboSkill.SelectedIndex = 0;
            cboWarp.SelectedIndex = 0;
            cboWarpDoom1.SelectedIndex = 0;
        }


        private void DisplayError(string message, string header)
        {
            MessageBox.Show(message, header, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void EnableProperWarpComboBox()
        {
            bool doom1Selected = lstIWads.SelectedIndex != -1 ? 
                lstIWads.SelectedItem.ToString() == "doom.wad" | lstIWads.SelectedItem.ToString() == "heretic.wad" 
                : false;

            cboWarp.Enabled = !doom1Selected;
            cboWarp.Visible = !doom1Selected;
            cboWarpDoom1.Enabled = doom1Selected;
            cboWarpDoom1.Visible = doom1Selected;
        }


        private void LoadFiles(string fileDirectory, string fileType)
        {
            if (!Directory.Exists(fileDirectory))
                return;

            string[] allFiles = Directory.GetFiles(fileDirectory);
            string[] splitPath;
            string fileToLoad;

            foreach (string file in allFiles)
            {
                if (!file.ToLower().EndsWith(fileType))
                    continue;

                splitPath = file.Split('\\');
                fileToLoad = splitPath[splitPath.Length - 1].ToLower();

                if (fileType == ".wad")
                {
                    if (CheckIfValidIWad(fileToLoad))
                    {
                        lstIWads.Items.Add(fileToLoad);
                    }
                    else
                    {
                        lstPWads.Items.Add(fileToLoad);
                    }
                }
                else if (fileType == ".deh")
                {
                    lstPWads.Items.Add(fileToLoad);
                }
                else if (fileType == ".lmp")
                {
                    lstDemos.Items.Add(fileToLoad);
                }
            }
        }


        private void LoadDemos()
        {
            LoadFiles(launcherConfig.DemoDirectory!, ".lmp");
        }


        private void LoadWads()
        {
            LoadFiles(launcherConfig.WadDirectory!, ".wad"); // More work than necessary; combine.
            LoadFiles(launcherConfig.WadDirectory!, ".deh"); // More work than necessary; combine.
            lstPWads.Sorted = true; // Puts same-named .deh next to .wad files.
        }


        private string PrepareLaunchCommand()
        {
            StringBuilder launchCommand = new StringBuilder();
            launchCommand.Append($"-iwad \"{launcherConfig.WadDirectory + @"\" + lstIWads.SelectedItem}\" ");

            if (lstPWads.SelectedIndices.Count > 0)
            {
                launchCommand.Append($"-file ");
                foreach (object wad in lstPWads.SelectedItems)
                {
                    launchCommand.Append($"\"{launcherConfig.WadDirectory + @"\" + wad}\" ");
                }
            }

            if (!pnlPlaySettings.Enabled) // Early exit if only playing demo file.
            {
                launchCommand.Append($"-playdemo \"{launcherConfig.DemoDirectory + @"\" + lstDemos.SelectedItem}\" ");
                
                if (!string.IsNullOrWhiteSpace(txtOptionalDemoArgs.Text))
                {
                    launchCommand.Append(txtOptionalDemoArgs.Text);
                }
                return launchCommand.ToString();
            }

            if (cboCompLevel.SelectedIndex > 0) // Allows for default comp level.
            {
                launchCommand.Append($"-complevel {cboCompLevel.SelectedItem} ");
            }

            if (cboWarp.Enabled && cboWarp.SelectedIndex > 0) // Allows for main menu access.
            {
                launchCommand.Append($"-warp {cboWarp.SelectedIndex} ");
            }
            else if (cboWarpDoom1.Enabled && cboWarpDoom1.SelectedIndex > 0) // Allows for main menu access in Doom1, Heretic.
            {
                string mapCode = cboWarpDoom1.SelectedItem.ToString()!; // Can't be null since index selected.
                launchCommand.Append($"-warp {mapCode[1]} {mapCode[3]} ");
            }

            if (cboSkill.SelectedIndex > 0) // Allows for main menu access.
            {
                launchCommand.Append($"-skill {cboSkill.SelectedIndex} ");
            }
            if (chkNoMonsters.Checked)
            {
                launchCommand.Append($"-nomonsters ");
            }
            if (chkFast.Checked)
            {
                launchCommand.Append($"-fast ");
            }
            if (chkRespawn.Checked)
            {
                launchCommand.Append($"-respawn ");
            }
            if (chkNoMusic.Checked)
            {
                launchCommand.Append($"-nomusic ");
            }
            if (chkShortTics.Checked)
            {
                launchCommand.Append($"-shorttics ");
            }
            if (chkSoloNet.Checked)
            {
                launchCommand.Append($"-solo-net ");
            }
            if (chkRecordDemo.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtDemoName.Text))
                {
                    DisplayError($"Please choose a name for your demo.", "No demo filename.");
                    return ""; // Checked for in TryLaunchDoom, which aborts process.
                }
                if (txtDemoName.Text.Contains(" "))
                {
                    DisplayError($"Please remove whitespace from your demo name.", "Whitespace in filename.");
                    return ""; // Checked for in TryLaunchDoom, which aborts process.
                }

                launchCommand.Append($"-record {txtDemoName.Text} ");
            }
            if (!string.IsNullOrWhiteSpace(txtOptionalArgs.Text))
            {
                launchCommand.Append(txtOptionalArgs.Text);
            }

            return launchCommand.ToString();
        }


        private void SaveSettings()
        {
            launcherConfig.Sourceport = lblSourcePort.Text;
            launcherConfig.SelectedIWad = lstIWads.SelectedItem.ToString(); //btnPlay_Click guarantees not null.
            launcherConfig.SelectedPWads ??= new List<string>();
            launcherConfig.SelectedPWads.Clear(); // If list was not null, it may be populated still.

            foreach (object wad in lstPWads.SelectedItems) // SelectedItems can be empty collection; never null.
            {
                launcherConfig.SelectedPWads.Add(wad.ToString()!);
            }

            launcherConfig.CompLevelIndex = cboCompLevel.SelectedIndex;
            launcherConfig.WarpIndex = cboWarp.SelectedIndex;
            launcherConfig.WarpIndexDoom1 = cboWarpDoom1.SelectedIndex;
            launcherConfig.SkillIndex = cboSkill.SelectedIndex;
            launcherConfig.NoMonsters = chkNoMonsters.Checked;
            launcherConfig.Fast = chkFast.Checked;
            launcherConfig.Respawn = chkRespawn.Checked;
            launcherConfig.NoMusic = chkNoMusic.Checked;
            launcherConfig.SoloNet = chkSoloNet.Checked;
            launcherConfig.Shorttics = chkShortTics.Checked;
            launcherConfig.RecordDemo = chkRecordDemo.Checked;
            launcherConfig.RecordDemoName = txtDemoName.Text;
            launcherConfig.OptionalArgs = txtOptionalArgs.Text;
            launcherConfig.OptionalDemoArgs = txtOptionalDemoArgs.Text;
            launcherConfig.PlayDemoName = lstDemos.SelectedIndex > -1 ? lstDemos.SelectedItem.ToString() : null;
            launcherConfig.InPlayDemosMode = !pnlPlaySettings.Enabled;
            launcherConfig.CloseLauncherOnPlay = chkClose.Checked;

            File.WriteAllText(savePath, JsonSerializer.Serialize(launcherConfig, 
                new JsonSerializerOptions() { WriteIndented = true }));
        }


        private void SetLoadSavePath()
        {
            try
            {
                savePath = Environment.CurrentDirectory + saveFile;
            }
            catch
            {
                DisplayError($"Can't find current directory or don't have permission to access it. " +
                    $"Please move me somewhere else.", "Directory Lookup Error.");
                Application.Exit();
            }
        }


        private void TryLaunchDoom(string launchCommand)
        {
            if (launchCommand == "") // Empty in case of unnamed demo during recording attempt.
                return;

            SaveSettings(); // Only want to save if launch command successfully built.

            try
            {
                // btnPlay_Click error handling ensures SourceportPath is never null.
                System.Diagnostics.Process.Start(launcherConfig.SourceportPath!, launchCommand);
                
                if (chkClose.Checked)
                {
                    Application.Exit();
                }
            }
            catch (FileNotFoundException)
            {
                DisplayError($"Your {lblSourcePort.Text} can't be found. " +
                    $"Have you moved or deleted it since your last session?", "Whoa hold on.");
            }
            catch
            {
                DisplayError($"Something went wrong. You can try again or inform me of the error" +
                    $" by reaching out on itch, Discord, Twitch, or YouTube.", "Unknown error.");
            }
        }


        private void TryLoadSettings()
        {
            if (!File.Exists(savePath))
            {
                DefaultComboBoxes(); // So boxes read "Default" instead of blank.
                return;
            }

            try
            {
                launcherConfig = JsonSerializer.Deserialize<LauncherConfig>(File.ReadAllText(savePath))!; // Assert now, check later.

                if (launcherConfig is null) // Still not convinced this is even possible, but just in case.
                {
                    launcherConfig = new LauncherConfig();
                    DefaultComboBoxes();
                    return;
                }
            }
            catch // In case user manually edits/deletes contents of .json file.
            {
                DisplayError("No JSON token found in .json file. Aborting load of last session.", "Unrecognized Data");
                DefaultComboBoxes();
                return;
            }

            LoadWads();
            LoadDemos();

            lblSourcePort.Text = launcherConfig.Sourceport;
            lstIWads.SelectedIndex = lstIWads.FindString(launcherConfig.SelectedIWad);

            if (launcherConfig.SelectedPWads is not null)
            {
                foreach (string pwad in launcherConfig.SelectedPWads)
                {
                    int index = lstPWads.FindString(pwad);
                    if (index == -1)
                        continue;

                    lstPWads.SetSelected(index, true);
                }
            }

            cboCompLevel.SelectedIndex = launcherConfig.CompLevelIndex;
            cboSkill.SelectedIndex = launcherConfig.SkillIndex;
            cboWarp.SelectedIndex = launcherConfig.WarpIndex;
            cboWarpDoom1.SelectedIndex = launcherConfig.WarpIndexDoom1;
            chkNoMonsters.Checked = launcherConfig.NoMonsters;
            chkFast.Checked = launcherConfig.Fast;
            chkRespawn.Checked = launcherConfig.Respawn;
            chkNoMusic.Checked = launcherConfig.NoMusic;
            chkSoloNet.Checked = launcherConfig.SoloNet;
            chkShortTics.Checked = launcherConfig.Shorttics;
            chkRecordDemo.Checked = launcherConfig.RecordDemo;
            txtDemoName.Text = launcherConfig.RecordDemoName;
            txtOptionalArgs.Text = launcherConfig.OptionalArgs;
            txtOptionalDemoArgs.Text = launcherConfig.OptionalDemoArgs;
            lstDemos.SelectedIndex = lstDemos.FindString(launcherConfig.PlayDemoName);
            chkClose.Checked = launcherConfig.CloseLauncherOnPlay;

            if (chkRecordDemo.Checked)
            {
                txtDemoName.Enabled = true;
            }
            if (chkNoMonsters.Checked)
            {
                chkFast.Enabled = false;
                chkRespawn.Enabled = false;
            }

            EnableProperWarpComboBox();
            ChangeMode(launcherConfig.InPlayDemosMode);

            return;
        }
        #endregion

        #region WinForms Controls Events
        private void btnDemoDirectory_Click(object sender, EventArgs e)
        {
            if (!ChangeDirectory("Please select your demos folder.", out string newDirectory))
                return;

            launcherConfig.DemoDirectory = newDirectory;
            lstDemos.Items.Clear();
            LoadDemos();
        }


        private void btnDemoMode_Click(object sender, EventArgs e)
        {
            ChangeMode(true);
        }


        private void btnDeselectPWad_Click(object sender, EventArgs e)
        {
            lstPWads.SelectedIndex = -1;
        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!lblSourcePort.Text.EndsWith(".exe"))
            {
                DisplayError("No source port selected.", "You goofed!");
                return;
            }

            if (lstIWads.SelectedIndex == -1)
            {
                DisplayError("No iwad selected.", "You goofed!");
                return;
            }

            if (!pnlPlaySettings.Enabled && lstDemos.SelectedIndex == -1)
            {
                DisplayError("No demo selected.", "You goofed!");
                return;
            }

            TryLaunchDoom(PrepareLaunchCommand());
        }


        private void btnPlayMode_Click(object sender, EventArgs e)
        {
            ChangeMode(false);
        }


        private void btnSourcePort_Click(object sender, EventArgs e)
        {
            ChangeSourcePort();
        }


        private void btnWadDirectory_Click(object sender, EventArgs e)
        {
            if (!ChangeDirectory("Please select your wads folder.", out string newDirectory))
                return;

            launcherConfig.WadDirectory = newDirectory;
            lstIWads.Items.Clear();
            lstPWads.Items.Clear();
            LoadWads();
        }


        private void chkNoMonsters_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNoMonsters.Checked)
            {
                chkFast.Checked = false;
                chkRespawn.Checked = false;
            }
            chkFast.Enabled = !chkNoMonsters.Checked;
            chkRespawn.Enabled = !chkNoMonsters.Checked;
        }


        private void chkRecordDemo_CheckedChanged(object sender, EventArgs e)
        {
            txtDemoName.Enabled = chkRecordDemo.Checked;
        }


        private void lstIWads_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableProperWarpComboBox();
        }
        #endregion
    }
}