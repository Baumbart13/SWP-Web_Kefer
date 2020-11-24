using System;
using System.Collections.Generic;

namespace ModDB_Rebuild.Models
{
    public class Mod
    {
		private List<ModFile> mod_modFiles = new List<ModFile>();
		private static uint mod_currentModId = 0;

		public ModGenre Mod_ModGenre { get; }
        public uint Mod_ID { get; }
		public string Mod_Game { get; }
        public string Mod_Name { get; set; }
        public string Mod_Description { get; set; }
        public DateTime? Mod_ReleaseDate { get; set; }
        
		public List<ModFile> Mod_ModFiles {
			get {
				List<ModFile> output = new List<ModFile>(mod_modFiles.Count);
				foreach (var item in mod_modFiles) {
					output.Add(item);
				};
				return output;
			}
			set {
				if(value.GetType() != mod_modFiles.GetType() || value == null) {
					return;
				}

				foreach(var item in value) {
					mod_modFiles.Add(item);
				}
			}
		}

		public Mod() : this("", "", "", DateTime.Now, new ModFile()) { }

		public Mod(string mod_game, string mod_name, string mod_description, DateTime? mod_releaseDate, ModFile mod_modFile) {
			this.Mod_ID = ++Mod.mod_currentModId;
			this.Mod_Game = mod_game;
			this.Mod_Name = mod_name;
			this.Mod_Description = mod_description;
			this.Mod_ReleaseDate = mod_releaseDate;

			//this.Mod_ModFiles = mod_modFile;
		}
    }
}