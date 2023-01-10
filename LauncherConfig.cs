using System.Collections.Generic;

namespace DoomLauncher
{
    internal class LauncherConfig
    {
        public string? SourceportPath { get; set; }
        public string? Sourceport { get; set; } // Used to append path and for label text.
        public string? WadDirectory { get; set; }
        public string? DemoDirectory { get; set; }

        public string? SelectedIWad { get; set; }
        public List<string>? SelectedPWads { get; set; }
        public int CompLevelIndex { get; set; }
        public int WarpIndex { get; set; }
        public int WarpIndexDoom1 { get; set; }
        public int SkillIndex { get; set; }

        public bool NoMonsters { get; set; }
        public bool Fast { get; set; }
        public bool Respawn { get; set; }
        public bool NoMusic { get; set; }
        public bool SoloNet { get; set; }
        public bool Shorttics { get; set; }
        public bool RecordDemo { get; set; }
        public string? RecordDemoName { get; set; }
        public string? OptionalArgs { get; set; }

        public bool InPlayDemosMode { get; set; }
        public string? PlayDemoName { get; set; }

        public bool CloseLauncherOnPlay { get; set; }
    }
}
