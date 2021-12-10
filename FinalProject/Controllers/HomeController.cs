﻿using FinalProject.Models;
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

        public IActionResult Search()
        {
            return View();
        }


        public IActionResult SearchResults(Search s)
        {
            List<string> results = new List<string>();

            var characters = cntxt.Characters.Where(c => c.CharName.Contains(s.Query)).ToList();

            foreach(CharacterModel c in characters)
            {
                results.Add(c.CharName);
            }

            ViewBag.results = results;
            return View();

        }

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
