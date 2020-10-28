﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NetCandyStore.Models;

namespace NetCandyStore.Controllers
{
    public class HomeController : Controller
    {
        private CandiesDBEntities db = new CandiesDBEntities();
        public ActionResult Index()
        {
            return View(db.ProductCategories.ToList());
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