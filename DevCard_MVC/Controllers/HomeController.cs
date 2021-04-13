﻿using Aspose.Pdf.Facades;
using DevCard_MVC.Models;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact() => View();

        ////[HttpPost]

        ////public JsonResult Contact(IFormCollection form)
        ////{
        ////    var ame = form["name"];
        ////    return Json(Ok());

        ////}
        [HttpPost]
        public JsonResult Contact(Contact form)
        {
            Console.Write(form.ToString());
            return Json(Ok());

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
