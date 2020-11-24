using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModDB_Rebuild.Models{

    public class ModFile{
		public string ModFile_Content { get; set; }
		public string ModFile_Path { get; set; }
		public bool ModFile_IsAbsolutePath { get; }

		public ModFile() : this("", "", true){}
		/// <summary>
		/// Constructor of ModFile
		/// </summary>
		/// <param name="modFile_file">The bytes of the ModFile</param>
		/// <param name="modFile_path">The path to the ModFile, which should be in the game-directory for most games</param>
		/// <param name="modFile_isAbsolutePath">By default it is false, because otherwise it is quite hard to implement the ModFile into the game</param>
		public ModFile(string modFile_file, string modFile_path, bool modFile_isAbsolutePath) {
			this.ModFile_Content = modFile_file;
			this.ModFile_Path = modFile_path;
			this.ModFile_IsAbsolutePath = modFile_isAbsolutePath;
		}
    }
}
