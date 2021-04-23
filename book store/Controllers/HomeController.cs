using book_store.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Controllers
{
    public class HomeController : Controller
    {

        
        
        public IActionResult Index()

        {

            return View();
        }
     
        //public IActionResult Portfolio()
        //{
        //    return View();
        //}
        //public IActionResult Experience()
        //{

        //    return View();
        //}
        //public IActionResult Client()
        //{

        //    return View();
        //}
        [HttpGet]
        public IActionResult Contact()
        {

            var model = new Contact();
            return View(model);
        }
        [HttpPost]
        public PartialViewResult Contact(Contact form)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اعطلاعات وارد شده صحیح نمیباشد";
                return PartialView(form);
            }
            ViewBag.success = "پیام شما با موفقیت ارسال شد";
            ModelState.Clear();
            return PartialView();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
