using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModDB_Rebuild.Models {
	/*
<optgroup label="Action">
	<option value="3">First Person Shooter</option>
	<option value="34">Third Person Shooter</option>
	<option value="4">Tactical Shooter</option>
	<option value="20">Fighting</option>
	<option value="39">Arcade</option>
	<option value="43">Stealth</option>
</optgroup>
<optgroup label="Adventure">
	<option value="2">Adventure</option>
	<option value="19">Platformer</option>
	<option value="40">Point and Click</option>
	<option value="50">Visual Novel</option>
</optgroup>
<optgroup label="Driving">
	<option value="7">Racing</option>
	<option value="8">Car Combat</option>
</optgroup>
<optgroup label="RPG">
	<option value="11">Role Playing</option>
	<option value="44">Roguelike</option>
	<option value="51">Hack 'n' Slash</option>
	<option value="53">Party Based</option>
</optgroup>
<optgroup label="Strategy">
	<option value="15">Real Time Strategy</option>
	<option value="42">Real Time Shooter</option>
	<option value="45">Real Time Tactics</option>
	<option value="16">Turn Based Strategy</option>
	<option value="46">Turn Based Tactics</option>
	<option value="47">Tower Defense</option>
	<option value="49">Grand Strategy</option>
	<option value="48">4X</option>
	<option value="52">MOBA</option>
</optgroup>
<optgroup label="Sport">
	<option value="13">Baseball</option>
	<option value="17">Basketball</option>
	<option value="21">Football</option>
	<option value="33">Golf</option>
	<option value="35">Hockey</option>
	<option value="36">Soccer</option>
	<option value="37">Wrestling</option>
	<option value="26">Sport</option>
</optgroup>
<optgroup label="Simulation">
	<option value="24">Combat Sim</option>
	<option value="25">Futuristic Sim</option>
	<option value="23">Realistic Sim</option>
</optgroup>
<optgroup label="Puzzle">
	<option value="41">Cinematic</option>
	<option value="38">Educational</option>
	<option value="31">Family</option>
	<option value="29">Party</option>
	<option value="28">Rhythm</option>
	<option value="30">Virtual Life</option>
	<option value="32">Puzzle</option>
</optgroup>
	 */

	public class ModGenre {
		public enum ModGenreGroups {
			Action, Adventure, Driving, RPG, Strategy, Sport, Simulation, Puzzle
		}

		private Dictionary<string, string> ModGenre_Genres = new Dictionary<string, string> {
			{nameof(ModGenreGroups.Action), "First Person Shooter" },
			{nameof(ModGenreGroups.Action), "Third Person Shooter"},
			{nameof(ModGenreGroups.Action), "Tactical Shooter"},
			{nameof(ModGenreGroups.Action), "Fighting" },
			{nameof(ModGenreGroups.Action), "Arcade" },
			{nameof(ModGenreGroups.Action), "Stealth" },
			{nameof(ModGenreGroups.Adventure), "Adventure" },
			{nameof(ModGenreGroups.Adventure), "Platformer" },
			{nameof(ModGenreGroups.Adventure), "Point and Click" },
			{nameof(ModGenreGroups.Adventure), "Visual Novel" },
			{nameof(ModGenreGroups.Driving), "Racing" },
			{nameof(ModGenreGroups.Driving), "Car Combat" },
			{nameof(ModGenreGroups.RPG), "Role Playing" },
			{nameof(ModGenreGroups.RPG), "Roguelike" },
			{nameof(ModGenreGroups.RPG), "Hack \'n\' Slash" },
			{nameof(ModGenreGroups.RPG), "Party Based" },
			{nameof(ModGenreGroups.Strategy), "Real Time Strategy" },
			{nameof(ModGenreGroups.Strategy), "Real Time Shooter" },
			{nameof(ModGenreGroups.Strategy), "Real Time Tactics" },
			{nameof(ModGenreGroups.Strategy), "Turn Based Strategy" },
			{nameof(ModGenreGroups.Strategy), "Turn Based Tactics" },
			{nameof(ModGenreGroups.Strategy), "Tower Defense" },
			{nameof(ModGenreGroups.Strategy), "Grand Strategy" },
			{nameof(ModGenreGroups.Strategy), "4X" },
			{nameof(ModGenreGroups.Strategy), "MOBA" },
			{nameof(ModGenreGroups.Sport), "Baseball" },
			{nameof(ModGenreGroups.Sport), "Basketball" },
			{nameof(ModGenreGroups.Sport), "Football" },
			{nameof(ModGenreGroups.Sport), "Golf" },
			{nameof(ModGenreGroups.Sport), "Hokey" },
			{nameof(ModGenreGroups.Sport), "Soccer" },
			{nameof(ModGenreGroups.Sport), "Wrestling" },
			{nameof(ModGenreGroups.Sport), "Sport" },
			{nameof(ModGenreGroups.Simulation),  "Combat Sim" },
			{nameof(ModGenreGroups.Simulation), "Futuristic Sim" },
			{nameof(ModGenreGroups.Simulation), "Realistic Sim" },
			{nameof(ModGenreGroups.Puzzle), "Cinematics" },
			{nameof(ModGenreGroups.Puzzle), "Educational" },
			{nameof(ModGenreGroups.Puzzle), "Family" },
			{nameof(ModGenreGroups.Puzzle), "Party" },
			{nameof(ModGenreGroups.Puzzle), "Rhythm" },
			{nameof(ModGenreGroups.Puzzle), "Virtual Life" },
			{nameof(ModGenreGroups.Puzzle), "Puzzle" }
		};

		public List<string> GetValues(string key) {
			if (!ModGenre_Genres.ContainsKey(key)) {
				return null;
			}
			List<string> output = new List<string>();

			foreach(var item in ModGenre_Genres.Values) {
				output.Add(item);
			}

			return output;
		}
	}
}
