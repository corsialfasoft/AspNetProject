﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetProject.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        public ActionResult RichiestaOrdini() {
            return View();
        }
        public ActionResult carrello() {
            return View();
        }
        public ActionResult ConfermaOrdini() {
            return View();
        }
        public ActionResult DettaglioOrdine() {
            return View();
        }
    }
}