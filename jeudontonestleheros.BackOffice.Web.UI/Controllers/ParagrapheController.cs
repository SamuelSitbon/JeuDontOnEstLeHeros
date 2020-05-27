using jeudontonestleheros.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace jeudontonestleheros.BackOffice.Web.UI.Controllers
{
    public class ParagrapheController : Controller
    {
        #region A Supprimer après Entities
        private List<Paragraphe> _maList = new List<Paragraphe>()
        {
            new Paragraphe() {Id = 1, Numero = 1, Titre = "Titre 1" },
            new Paragraphe() {Id = 2, Numero = 10, Titre = "Titre 2" },
            new Paragraphe() {Id = 5, Numero = 14, Titre = "Titre 3" }
        };
        #endregion

        #region Méthodes publiques
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Paragraphe paragraphe)
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            Paragraphe paragraphe = null;

            paragraphe = _maList.First(item => item.Id == id);

            return View(paragraphe);
        }
        #endregion
    }
}
