﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace re259315_MIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Personal Information Page";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Information";

            return View();
        }

        
    }
}