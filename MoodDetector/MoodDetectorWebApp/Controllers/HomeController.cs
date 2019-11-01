﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoodDetectorWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This project uses emotion recognition to give teachers feedback about their lectures by analyzing students' mood.";

            return View();
        }

        public ActionResult Detector()
        {
            ViewBag.Message = "Recognise emotions in photos";

            return View();
        }
    }
}