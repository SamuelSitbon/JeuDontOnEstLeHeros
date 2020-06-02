using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestleheros.Core.Data;
using jeudontonestleheros.Core.Data.Models;
using Jeudontonestlehéros.WEB.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jeudontonestlehéros.WEB.UI.Controllers
{
    public class AventureController : Controller
    {
        //autre méthode avec this_context.Aventures à la place de context.Aventures dans l'ActionResult
        //private readonly DefaultContext _context = null;
        //public AventureController(DefaultContext context)
        //{
        //    this._context = context;
        //}
        public IActionResult Index([FromServices] DefaultContext context)
        {
            this.ViewBag.MonTitre = "Aventures";
            var query = from item in context.Aventures
                        select item;


            return View(query.ToList());
        }
    }
}