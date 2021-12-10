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
    public class MechanicsController : Controller
    {
        private ProjectContext cntxt;

        public MechanicsController(ProjectContext con)
        {
            cntxt = con;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TowerInfo()
        {
            return View();
        }

        public IActionResult TowerPage()
        {
            ViewBag.towers = cntxt.Towers.ToList();
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
