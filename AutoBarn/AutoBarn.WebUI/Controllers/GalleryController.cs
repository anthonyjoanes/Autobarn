﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Web;
using System.Web.Mvc;
using AutoBarn.WebUI.Services.Filters;

namespace AutoBarn.WebUI.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        public ActionResult Index()
        {
            ViewBag.CustomerReviews = MemoryCache.Default.Get("Review") as string;
            return View();
        }
    }
}