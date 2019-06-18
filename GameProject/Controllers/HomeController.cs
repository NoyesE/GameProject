using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameProject.Models;

namespace GameProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Player myPlayer = new Player
            {
                Name = "Ian",
                wood = 0,
                lumberHut = 0
            };
            return View(myPlayer);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}