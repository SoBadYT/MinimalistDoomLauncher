using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DoomLauncher
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSourcePort = new System.Windows.Forms.Button();
            this.lblSourcePort = new System.Windows.Forms.Label();
            this.lstIWads = new System.Windows.Forms.ListBox();
            this.lstPWads = new System.Windows.Forms.ListBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnDeselectPWad = new System.Windows.Forms.Button();
            this.cboCompLevel = new System.Windows.Forms.ComboBox();
            this.lblCompLevel = new System.Windows.Forms.Label();
            this.chkShortTics = new System.Windows.Forms.CheckBox();
            this.chkNoMonsters = new System.Windows.Forms.CheckBox();
            this.chkNoMusic = new System.Windows.Forms.CheckBox();
            this.chkRecordDemo = new System.Windows.Forms.CheckBox();
            this.txtDemoName = new System.Windows.Forms.TextBox();
            this.cboSkill = new System.Windows.Forms.ComboBox();
            this.lblSkill = new System.Windows.Forms.Label();
            this.lblWarp = new System.Windows.Forms.Label();
            this.cboWarp = new System.Windows.Forms.ComboBox();
            this.chkSoloNet = new System.Windows.Forms.CheckBox();
            this.lblIWads = new System.Windows.Forms.Label();
            this.lblPWads = new System.Windows.Forms.Label();
            this.chkFast = new System.Windows.Forms.CheckBox();
            this.chkRespawn = new System.Windows.Forms.CheckBox();
            this.cboWarpDoom1 = new System.Windows.Forms.ComboBox();
            this.btnWadDirectory = new System.Windows.Forms.Button();
            this.btnDemoMode = new System.Windows.Forms.Button();
            this.btnPlayMode = new System.Windows.Forms.Button();
            this.btnDemoDirectory = new System.Windows.Forms.Button();
            this.lblDemo = new System.Windows.Forms.Label();
            this.lstDemos = new System.Windows.Forms.ListBox();
            this.pnlPlaySettings = new System.Windows.Forms.Panel();
            this.txtOptionalArgs = new System.Windows.Forms.TextBox();
            this.lblOptionalArgs = new System.Windows.Forms.Label();
            this.chkClose = new System.Windows.Forms.CheckBox();
            this.pnlPlaySettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSourcePort
            // 
            this.btnSourcePort.Location = new System.Drawing.Point(14, 14);
            this.btnSourcePort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSourcePort.Name = "btnSourcePort";
            this.btnSourcePort.Size = new System.Drawing.Size(105, 27);
            this.btnSourcePort.TabIndex = 0;
            this.btnSourcePort.Text = "Source Port";
            this.btnSourcePort.UseVisualStyleBackColor = true;
            this.btnSourcePort.Click += new System.EventHandler(this.btnSourcePort_Click);
            // 
            // lblSourcePort
            // 
            this.lblSourcePort.AutoSize = true;
            this.lblSourcePort.Location = new System.Drawing.Point(14, 44);
            this.lblSourcePort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSourcePort.Name = "lblSourcePort";
            this.lblSourcePort.Size = new System.Drawing.Size(134, 15);
            this.lblSourcePort.TabIndex = 1;
            this.lblSourcePort.Text = "No Source Port Selected";
            // 
            // lstIWads
            // 
            this.lstIWads.FormattingEnabled = true;
            this.lstIWads.ItemHeight = 15;
            this.lstIWads.Location = new System.Drawing.Point(14, 126);
            this.lstIWads.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstIWads.Name = "lstIWads";
            this.lstIWads.Size = new System.Drawing.Size(216, 79);
            this.lstIWads.TabIndex = 2;
            this.lstIWads.SelectedIndexChanged += new System.EventHandler(this.lstIWads_SelectedIndexChanged);
            // 
            // lstPWads
            // 
            this.lstPWads.FormattingEnabled = true;
            this.lstPWads.ItemHeight = 15;
            this.lstPWads.Location = new System.Drawing.Point(257, 38);
            this.lstPWads.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstPWads.Name = "lstPWads";
            this.lstPWads.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstPWads.Size = new System.Drawing.Size(181, 394);
            this.lstPWads.TabIndex = 4;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(14, 473);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(235, 50);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "PLAY DOOM";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnDeselectPWad
            // 
            this.btnDeselectPWad.Location = new System.Drawing.Point(351, 440);
            this.btnDeselectPWad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeselectPWad.Name = "btnDeselectPWad";
            this.btnDeselectPWad.Size = new System.Drawing.Size(88, 27);
            this.btnDeselectPWad.TabIndex = 7;
            this.btnDeselectPWad.Text = "Deselect";
            this.btnDeselectPWad.UseVisualStyleBackColor = true;
            this.btnDeselectPWad.Click += new System.EventHandler(this.btnDeselectPWad_Click);
            // 
            // cboCompLevel
            // 
            this.cboCompLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompLevel.FormattingEnabled = true;
            this.cboCompLevel.Items.AddRange(new object[] {
            "Default",
            "-1",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "21"});
            this.cboCompLevel.Location = new System.Drawing.Point(6, 37);
            this.cboCompLevel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCompLevel.Name = "cboCompLevel";
            this.cboCompLevel.Size = new System.Drawing.Size(73, 23);
            this.cboCompLevel.TabIndex = 9;
            // 
            // lblCompLevel
            // 
            this.lblCompLevel.AutoSize = true;
            this.lblCompLevel.Location = new System.Drawing.Point(6, 9);
            this.lblCompLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompLevel.Name = "lblCompLevel";
            this.lblCompLevel.Size = new System.Drawing.Size(73, 15);
            this.lblCompLevel.TabIndex = 10;
            this.lblCompLevel.Text = "Comp Level:";
            // 
            // chkShortTics
            // 
            this.chkShortTics.AutoSize = true;
            this.chkShortTics.Location = new System.Drawing.Point(118, 111);
            this.chkShortTics.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkShortTics.Name = "chkShortTics";
            this.chkShortTics.Size = new System.Drawing.Size(77, 19);
            this.chkShortTics.TabIndex = 15;
            this.chkShortTics.Text = "Short Tics";
            this.chkShortTics.UseVisualStyleBackColor = true;
            // 
            // chkNoMonsters
            // 
            this.chkNoMonsters.AutoSize = true;
            this.chkNoMonsters.Location = new System.Drawing.Point(6, 84);
            this.chkNoMonsters.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkNoMonsters.Name = "chkNoMonsters";
            this.chkNoMonsters.Size = new System.Drawing.Size(94, 19);
            this.chkNoMonsters.TabIndex = 16;
            this.chkNoMonsters.Text = "No Monsters";
            this.chkNoMonsters.UseVisualStyleBackColor = true;
            this.chkNoMonsters.CheckedChanged += new System.EventHandler(this.chkNoMonsters_CheckedChanged);
            // 
            // chkNoMusic
            // 
            this.chkNoMusic.AutoSize = true;
            this.chkNoMusic.Location = new System.Drawing.Point(118, 84);
            this.chkNoMusic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkNoMusic.Name = "chkNoMusic";
            this.chkNoMusic.Size = new System.Drawing.Size(77, 19);
            this.chkNoMusic.TabIndex = 17;
            this.chkNoMusic.Text = "No Music";
            this.chkNoMusic.UseVisualStyleBackColor = true;
            // 
            // chkRecordDemo
            // 
            this.chkRecordDemo.AutoSize = true;
            this.chkRecordDemo.Location = new System.Drawing.Point(118, 137);
            this.chkRecordDemo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkRecordDemo.Name = "chkRecordDemo";
            this.chkRecordDemo.Size = new System.Drawing.Size(98, 19);
            this.chkRecordDemo.TabIndex = 18;
            this.chkRecordDemo.Text = "Record Demo";
            this.chkRecordDemo.UseVisualStyleBackColor = true;
            this.chkRecordDemo.CheckedChanged += new System.EventHandler(this.chkRecordDemo_CheckedChanged);
            // 
            // txtDemoName
            // 
            this.txtDemoName.Enabled = false;
            this.txtDemoName.Location = new System.Drawing.Point(118, 160);
            this.txtDemoName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDemoName.Name = "txtDemoName";
            this.txtDemoName.Size = new System.Drawing.Size(116, 23);
            this.txtDemoName.TabIndex = 19;
            this.txtDemoName.Text = "demofilename";
            // 
            // cboSkill
            // 
            this.cboSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSkill.FormattingEnabled = true;
            this.cboSkill.Items.AddRange(new object[] {
            "Default",
            "ITYTD",
            "HNTR",
            "HMP",
            "UV",
            "NM"});
            this.cboSkill.Location = new System.Drawing.Point(87, 37);
            this.cboSkill.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboSkill.Name = "cboSkill";
            this.cboSkill.Size = new System.Drawing.Size(73, 23);
            this.cboSkill.TabIndex = 21;
            // 
            // lblSkill
            // 
            this.lblSkill.AutoSize = true;
            this.lblSkill.Location = new System.Drawing.Point(87, 9);
            this.lblSkill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSkill.Name = "lblSkill";
            this.lblSkill.Size = new System.Drawing.Size(31, 15);
            this.lblSkill.TabIndex = 22;
            this.lblSkill.Text = "Skill:";
            // 
            // lblWarp
            // 
            this.lblWarp.AutoSize = true;
            this.lblWarp.Location = new System.Drawing.Point(168, 9);
            this.lblWarp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarp.Name = "lblWarp";
            this.lblWarp.Size = new System.Drawing.Size(38, 15);
            this.lblWarp.TabIndex = 23;
            this.lblWarp.Text = "Warp:";
            // 
            // cboWarp
            // 
            this.cboWarp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWarp.FormattingEnabled = true;
            this.cboWarp.Items.AddRange(new object[] {
            "Default",
            "MAP01",
            "MAP02",
            "MAP03",
            "MAP04",
            "MAP05",
            "MAP06",
            "MAP07",
            "MAP08",
            "MAP09",
            "MAP10",
            "MAP11",
            "MAP12",
            "MAP13",
            "MAP14",
            "MAP15",
            "MAP16",
            "MAP17",
            "MAP18",
            "MAP19",
            "MAP20",
            "MAP21",
            "MAP22",
            "MAP23",
            "MAP24",
            "MAP25",
            "MAP26",
            "MAP27",
            "MAP28",
            "MAP29",
            "MAP30",
            "MAP31",
            "MAP32",
            "MAP33",
            "MAP34",
            "MAP35",
            "MAP36",
            "MAP37",
            "MAP38",
            "MAP39",
            "MAP40",
            "MAP41",
            "MAP42",
            "MAP43",
            "MAP44",
            "MAP45",
            "MAP46",
            "MAP47",
            "MAP48",
            "MAP49",
            "MAP50",
            "MAP51",
            "MAP52",
            "MAP53",
            "MAP54",
            "MAP55",
            "MAP56",
            "MAP57",
            "MAP58",
            "MAP59",
            "MAP60",
            "MAP61",
            "MAP62",
            "MAP63",
            "MAP64",
            "MAP65",
            "MAP66",
            "MAP67",
            "MAP68",
            "MAP69",
            "MAP70",
            "MAP71",
            "MAP72",
            "MAP73",
            "MAP74",
            "MAP75",
            "MAP76",
            "MAP77",
            "MAP78",
            "MAP79",
            "MAP80",
            "MAP81",
            "MAP82",
            "MAP83",
            "MAP84",
            "MAP85",
            "MAP86",
            "MAP87",
            "MAP88",
            "MAP89",
            "MAP90",
            "MAP91",
            "MAP92",
            "MAP93",
            "MAP94",
            "MAP95",
            "MAP96",
            "MAP97",
            "MAP98",
            "MAP99"});
            this.cboWarp.Location = new System.Drawing.Point(168, 37);
            this.cboWarp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboWarp.Name = "cboWarp";
            this.cboWarp.Size = new System.Drawing.Size(73, 23);
            this.cboWarp.TabIndex = 24;
            // 
            // chkSoloNet
            // 
            this.chkSoloNet.AutoSize = true;
            this.chkSoloNet.Location = new System.Drawing.Point(6, 162);
            this.chkSoloNet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkSoloNet.Name = "chkSoloNet";
            this.chkSoloNet.Size = new System.Drawing.Size(71, 19);
            this.chkSoloNet.TabIndex = 25;
            this.chkSoloNet.Text = "Solo Net";
            this.chkSoloNet.UseVisualStyleBackColor = true;
            // 
            // lblIWads
            // 
            this.lblIWads.AutoSize = true;
            this.lblIWads.Location = new System.Drawing.Point(14, 108);
            this.lblIWads.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIWads.Name = "lblIWads";
            this.lblIWads.Size = new System.Drawing.Size(37, 15);
            this.lblIWads.TabIndex = 26;
            this.lblIWads.Text = "IWad:";
            // 
            // lblPWads
            // 
            this.lblPWads.AutoSize = true;
            this.lblPWads.Location = new System.Drawing.Point(257, 20);
            this.lblPWads.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPWads.Name = "lblPWads";
            this.lblPWads.Size = new System.Drawing.Size(41, 15);
            this.lblPWads.TabIndex = 27;
            this.lblPWads.Text = "PWad:";
            // 
            // chkFast
            // 
            this.chkFast.AutoSize = true;
            this.chkFast.Location = new System.Drawing.Point(6, 111);
            this.chkFast.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkFast.Name = "chkFast";
            this.chkFast.Size = new System.Drawing.Size(47, 19);
            this.chkFast.TabIndex = 28;
            this.chkFast.Text = "Fast";
            this.chkFast.UseVisualStyleBackColor = true;
            // 
            // chkRespawn
            // 
            this.chkRespawn.AutoSize = true;
            this.chkRespawn.Location = new System.Drawing.Point(6, 137);
            this.chkRespawn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkRespawn.Name = "chkRespawn";
            this.chkRespawn.Size = new System.Drawing.Size(73, 19);
            this.chkRespawn.TabIndex = 29;
            this.chkRespawn.Text = "Respawn";
            this.chkRespawn.UseVisualStyleBackColor = true;
            // 
            // cboWarpDoom1
            // 
            this.cboWarpDoom1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWarpDoom1.Enabled = false;
            this.cboWarpDoom1.FormattingEnabled = true;
            this.cboWarpDoom1.Items.AddRange(new object[] {
            "Default",
            "E1M1",
            "E1M2",
            "E1M3",
            "E1M4",
            "E1M5",
            "E1M6",
            "E1M7",
            "E1M8",
            "E1M9",
            "E2M1",
            "E2M2",
            "E2M3",
            "E2M4",
            "E2M5",
            "E2M6",
            "E2M7",
            "E2M8",
            "E2M9",
            "E3M1",
            "E3M2",
            "E3M3",
            "E3M4",
            "E3M5",
            "E3M6",
            "E3M7",
            "E3M8",
            "E3M9",
            "E4M1",
            "E4M2",
            "E4M3",
            "E4M4",
            "E4M5",
            "E4M6",
            "E4M7",
            "E4M8",
            "E4M9",
            "E5M1",
            "E5M2",
            "E5M3",
            "E5M4",
            "E5M5",
            "E5M6",
            "E5M7",
            "E5M8",
            "E5M9",
            "E6M1",
            "E6M2",
            "E6M3",
            "E6M4",
            "E6M5",
            "E6M6",
            "E6M7",
            "E6M8",
            "E6M9"});
            this.cboWarpDoom1.Location = new System.Drawing.Point(168, 37);
            this.cboWarpDoom1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboWarpDoom1.Name = "cboWarpDoom1";
            this.cboWarpDoom1.Size = new System.Drawing.Size(73, 23);
            this.cboWarpDoom1.TabIndex = 30;
            this.cboWarpDoom1.Visible = false;
            // 
            // btnWadDirectory
            // 
            this.btnWadDirectory.Location = new System.Drawing.Point(14, 66);
            this.btnWadDirectory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnWadDirectory.Name = "btnWadDirectory";
            this.btnWadDirectory.Size = new System.Drawing.Size(105, 27);
            this.btnWadDirectory.TabIndex = 31;
            this.btnWadDirectory.Text = "Wad Directory";
            this.btnWadDirectory.UseVisualStyleBackColor = true;
            this.btnWadDirectory.Click += new System.EventHandler(this.btnWadDirectory_Click);
            // 
            // btnDemoMode
            // 
            this.btnDemoMode.Location = new System.Drawing.Point(126, 14);
            this.btnDemoMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDemoMode.Name = "btnDemoMode";
            this.btnDemoMode.Size = new System.Drawing.Size(105, 27);
            this.btnDemoMode.TabIndex = 32;
            this.btnDemoMode.Text = "To Demo Mode";
            this.btnDemoMode.UseVisualStyleBackColor = true;
            this.btnDemoMode.Click += new System.EventHandler(this.btnDemoMode_Click);
            // 
            // btnPlayMode
            // 
            this.btnPlayMode.Enabled = false;
            this.btnPlayMode.Location = new System.Drawing.Point(127, 14);
            this.btnPlayMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPlayMode.Name = "btnPlayMode";
            this.btnPlayMode.Size = new System.Drawing.Size(105, 27);
            this.btnPlayMode.TabIndex = 33;
            this.btnPlayMode.Text = "To Play Mode";
            this.btnPlayMode.UseVisualStyleBackColor = true;
            this.btnPlayMode.Visible = false;
            this.btnPlayMode.Click += new System.EventHandler(this.btnPlayMode_Click);
            // 
            // btnDemoDirectory
            // 
            this.btnDemoDirectory.Enabled = false;
            this.btnDemoDirectory.Location = new System.Drawing.Point(126, 66);
            this.btnDemoDirectory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDemoDirectory.Name = "btnDemoDirectory";
            this.btnDemoDirectory.Size = new System.Drawing.Size(105, 27);
            this.btnDemoDirectory.TabIndex = 34;
            this.btnDemoDirectory.Text = "Demo Directory";
            this.btnDemoDirectory.UseVisualStyleBackColor = true;
            this.btnDemoDirectory.Visible = false;
            this.btnDemoDirectory.Click += new System.EventHandler(this.btnDemoDirectory_Click);
            // 
            // lblDemo
            // 
            this.lblDemo.AutoSize = true;
            this.lblDemo.Location = new System.Drawing.Point(14, 220);
            this.lblDemo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDemo.Name = "lblDemo";
            this.lblDemo.Size = new System.Drawing.Size(42, 15);
            this.lblDemo.TabIndex = 35;
            this.lblDemo.Text = "Demo:";
            this.lblDemo.Visible = false;
            // 
            // lstDemos
            // 
            this.lstDemos.Enabled = false;
            this.lstDemos.FormattingEnabled = true;
            this.lstDemos.ItemHeight = 15;
            this.lstDemos.Location = new System.Drawing.Point(14, 238);
            this.lstDemos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstDemos.Name = "lstDemos";
            this.lstDemos.Size = new System.Drawing.Size(216, 229);
            this.lstDemos.TabIndex = 36;
            this.lstDemos.Visible = false;
            // 
            // pnlPlaySettings
            // 
            this.pnlPlaySettings.Controls.Add(this.txtOptionalArgs);
            this.pnlPlaySettings.Controls.Add(this.lblOptionalArgs);
            this.pnlPlaySettings.Controls.Add(this.cboCompLevel);
            this.pnlPlaySettings.Controls.Add(this.lblCompLevel);
            this.pnlPlaySettings.Controls.Add(this.chkShortTics);
            this.pnlPlaySettings.Controls.Add(this.chkNoMonsters);
            this.pnlPlaySettings.Controls.Add(this.chkNoMusic);
            this.pnlPlaySettings.Controls.Add(this.cboWarpDoom1);
            this.pnlPlaySettings.Controls.Add(this.cboWarp);
            this.pnlPlaySettings.Controls.Add(this.chkRecordDemo);
            this.pnlPlaySettings.Controls.Add(this.chkRespawn);
            this.pnlPlaySettings.Controls.Add(this.txtDemoName);
            this.pnlPlaySettings.Controls.Add(this.chkFast);
            this.pnlPlaySettings.Controls.Add(this.cboSkill);
            this.pnlPlaySettings.Controls.Add(this.lblSkill);
            this.pnlPlaySettings.Controls.Add(this.lblWarp);
            this.pnlPlaySettings.Controls.Add(this.chkSoloNet);
            this.pnlPlaySettings.Location = new System.Drawing.Point(8, 217);
            this.pnlPlaySettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlPlaySettings.Name = "pnlPlaySettings";
            this.pnlPlaySettings.Size = new System.Drawing.Size(248, 250);
            this.pnlPlaySettings.TabIndex = 37;
            // 
            // txtOptionalArgs
            // 
            this.txtOptionalArgs.Location = new System.Drawing.Point(6, 224);
            this.txtOptionalArgs.MaxLength = 500;
            this.txtOptionalArgs.Name = "txtOptionalArgs";
            this.txtOptionalArgs.Size = new System.Drawing.Size(235, 23);
            this.txtOptionalArgs.TabIndex = 38;
            // 
            // lblOptionalArgs
            // 
            this.lblOptionalArgs.AutoSize = true;
            this.lblOptionalArgs.Location = new System.Drawing.Point(6, 206);
            this.lblOptionalArgs.Name = "lblOptionalArgs";
            this.lblOptionalArgs.Size = new System.Drawing.Size(118, 15);
            this.lblOptionalArgs.TabIndex = 39;
            this.lblOptionalArgs.Text = "Optional Arguments:";
            // 
            // chkClose
            // 
            this.chkClose.AutoSize = true;
            this.chkClose.Location = new System.Drawing.Point(289, 490);
            this.chkClose.Name = "chkClose";
            this.chkClose.Size = new System.Drawing.Size(149, 19);
            this.chkClose.TabIndex = 38;
            this.chkClose.Text = "Close Launcher on Play";
            this.chkClose.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 534);
            this.Controls.Add(this.chkClose);
            this.Controls.Add(this.lblIWads);
            this.Controls.Add(this.lstIWads);
            this.Controls.Add(this.pnlPlaySettings);
            this.Controls.Add(this.lstDemos);
            this.Controls.Add(this.lblDemo);
            this.Controls.Add(this.btnDemoDirectory);
            this.Controls.Add(this.btnPlayMode);
            this.Controls.Add(this.btnDemoMode);
            this.Controls.Add(this.btnWadDirectory);
            this.Controls.Add(this.lblPWads);
            this.Controls.Add(this.btnDeselectPWad);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lstPWads);
            this.Controls.Add(this.lblSourcePort);
            this.Controls.Add(this.btnSourcePort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoBad\'s Doom Launcher";
            this.pnlPlaySettings.ResumeLayout(false);
            this.pnlPlaySettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSourcePort;
        private Label lblSourcePort;
        private ListBox lstIWads;
        private ListBox lstPWads;
        private Button btnPlay;
        private Button btnDeselectPWad;
        private ComboBox cboCompLevel;
        private Label lblCompLevel;
        private CheckBox chkShortTics;
        private CheckBox chkNoMonsters;
        private CheckBox chkNoMusic;
        private CheckBox chkRecordDemo;
        private TextBox txtDemoName;
        private ComboBox cboSkill;
        private Label lblSkill;
        private Label lblWarp;
        private ComboBox cboWarp;
        private CheckBox chkSoloNet;
        private Label lblIWads;
        private Label lblPWads;
        private CheckBox chkFast;
        private CheckBox chkRespawn;
        private ComboBox cboWarpDoom1;
        private Button btnWadDirectory;
        private Button btnDemoMode;
        private Button btnPlayMode;
        private Button btnDemoDirectory;
        private Label lblDemo;
        private ListBox lstDemos;
        private Panel pnlPlaySettings;
        private TextBox txtOptionalArgs;
        private Label lblOptionalArgs;
        private CheckBox chkClose;
    }
}