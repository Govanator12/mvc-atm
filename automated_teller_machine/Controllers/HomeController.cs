﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace automated_teller_machine.Controllers
{
    public class HomeController : Controller
    {
        // GET /home/index
        [MyLoggingFilter]
        public ActionResult Index()
        {
            return View();
        }

        // GET /home/about
        [ActionName( ("about-this-atm"))]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("About");
        }


        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Having trouble? Send us a message!";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            //TODO: send message to HQ
            ViewBag.TheMessage = "Thanks, we got your message!";

            return View();
        }

        public ActionResult Foo()
        {
            return View("About");
        }

        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPNETMVC5ATM1";
            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }

            // return new HttpStatusCodeResult(403);
            // return Json(new {name = "serial", value = serial}, JsonRequestBehavior.AllowGet);
            return RedirectToAction("Index");
        }
    }
}