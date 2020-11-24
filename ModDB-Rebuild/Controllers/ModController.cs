using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModDB_Rebuild.Models;

namespace ModDB_Rebuild.Controllers
{
    public class ModController : Controller {

		public IActionResult Latest() {
			return View();
		}

		public IActionResult Top() {
			return View();
		}

        public IActionResult Index()
        {
            return View(CreatModList());
        }

        public IActionResult Mod()
        {
            return View();
        }

        public IActionResult ReturnMods()
        {
            return View();
        }


        private List<Models.Mod> CreatModList()
        {
			// normalerweise würden die Artikel aus einer DB-Tabelle geladen
			return new List<Mod>(){
				new Mod("Command and Conquer Generals Zero Hour", "Contra 009", "By Contra Team", DateTime.Now, new ModFile()),
                new Mod("Comamnd and Conquer Generals Zero Hour", "Shockwave", "By R.G. Mechanics", DateTime.Now, new ModFile()),
                new Mod("Command and Conquer Generals Zero Hour", "Rise of the Red", "By R.G. Mechanics", DateTime.Now, new ModFile()),
                new Mod("Silent Hunter IV", "Fall of the Rising Sun", "Huge overhaul mod", DateTime.Now, new ModFile())
            };
        }

        // HttpGet ... diese Methode wird aufgerufen, falls ein Link angeklickt wird (GET)
        [HttpGet]
        public IActionResult Add()
        {
            // rufen die zugehörige View auf und übergeben einen leeren Artikel
            // aufgrund dieses Artikels werden dann die Formularfelder erzeugt
            return View(new Mod());
        }

        // HttpPost ... diese Methode wird aufgerufen, falls das Formular mit POST abgesendet wurde
        // newArticle ... wenn das Formular abgesendet wird, werden die Eingabefelder den Feldern der
        //                Klasse zugewisen (es wird auf den Namen des Feldes geachtet)
        [HttpPost]
        public IActionResult Add(Mod mod)
        {
            // Parameter überprüfen
            if (mod == null)
            {
                return RedirectToAction("createNewMod");
            }

            //Eingabe des Benutzers überprüfen
            ValidateModData(mod);

            //falls ja -> Daten in einer DB-Tabelle abspeichern
            if (ModelState.IsValid)
            {
                //Daten in DB-Tabelle eintragen

                //falls die Eingaben richtig sind -> redirect zu Home/Index
                // TODO: wir werden nächste Woche eine eigene Meldungsseite erzeugen
                return RedirectToAction("index", "mod");
            }

            //falls nein -> das Formular mit den eingegebenen Daten anzeigen

            return View(mod);
        }

        private void ValidateModData(Mod m)
        {
            if (m == null) return;

            /*
             * if(a.ArticleName == null){
             *      a.ArticleName = "";
             * }else{
             *      a.ArticleName = a.ArticleName;
             * }
            */
            m.Mod_Name = m.Mod_Name ?? "";
            if (m.Mod_Name.Length < 5)
            {
				//                          Name des Feldes                 Die gewünschte Fehlermeldung
				ModelState.AddModelError(nameof(Models.Mod.Mod_Name), "The name of the Mod must have at least 5 signs");
            }

			if(m.Mod_Game.Length < 3)
			{
				ModelState.AddModelError(nameof(Models.Mod.Mod_Game), "No game accepted with length under 3 signs");
			}

            if (m.Mod_ReleaseDate == null ||
                m.Mod_ReleaseDate.Value.Subtract(DateTime.Now) < TimeSpan.Zero.Add(TimeSpan.FromDays(1)))
            {
				ModelState.AddModelError(nameof(Models.Mod.Mod_ReleaseDate), "A date must be given and can't be in the past");
            }

            
			if(m.Mod_ModFiles == null || m.Mod_ModFiles.Count < 1){
				ModelState.AddModelError(nameof(Models.Mod.Mod_ModFiles), "You must have at least 1 File to upload!");
			}
			foreach(var modFile in m.Mod_ModFiles)
			{
				if(modFile.ModFile_Content == null ||
					modFile.ModFile_Path == null)
				{
					return;
				}

				if (modFile.ModFile_IsAbsolutePath)
				{
					ModelState.AddModelError(nameof(Models.Mod.Mod_ModFiles), "It is strongly recommended to use a relative Path from the Mod_ModFiles to the Mod-Directory of the game!");
				}
			}
        }
    }
}