using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private ProjectContext cntxt;

        public HomeController(ProjectContext con)
        {
            cntxt = con;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(Search s)
        {
            List<string> results = new List<string>();

            var charas = cntxt.Characters.Where(c => c.CharName.Contains(s.Query)|| c.CharGender.Contains(s.Query)).ToList();
            foreach(CharacterModel c in charas)
            {
                results.Add(c.CharName);
            }

            ViewBag.results = results;
            return View("Search");

        }
        [HttpPost]
        public IActionResult SuggestionsQuestions()
        {
            return View();
        }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
