﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrabalhoIHC_MarcosFilho.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: Home/
        public ActionResult Sisvec()
        {
            return View();
        }

        public ActionResult Inicio()
        {
            return View();
        }
    }
}