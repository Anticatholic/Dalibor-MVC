using Dalibor_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dalibor_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Vzdelanie()
        {
            VzdelanieModel skola=new VzdelanieModel();
            skola.ZakladnaSkola = "Krššáková";
            skola.StrednaSkola = "Handlová";
            skola.PriemyselnaSkola = "Vyššie odborné vzdelanie";
            return View(skola);
        }

        public ActionResult Omne()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Zamestnanie()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Intro()
        {
            return View();
        }

        public ActionResult Galeria()
        {
            return View();


        }

        public ActionResult Kontakt()
        {
            KontaktModel model = new KontaktModel();
            return View(model);
        }
    }
}