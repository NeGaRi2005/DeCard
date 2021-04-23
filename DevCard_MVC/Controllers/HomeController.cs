using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;


namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Service> _services = new List<Service>
        {
            new Service(1, "نقره ای"),
            new Service(2, "طلایی"),
            new Service(3, "پلاتین"),
            new Service(4, "الماس"),
        };

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact
            {
                Service = new SelectList(_services, "Id", "Name")
            };
            return View(model);
        }



        //public JsonResult Contact(IFormCollection form)
        //        {
        //            var Name = form["name"];
        //            return Json(Ok());
        //        }
        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            model.Service = new SelectList(_services, "Id", "Name");
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اعطلاعات وارد شده صحیح نمیباشد";
                return View(model);
            }
            ModelState.Clear();
            model = new Contact
            {
                Service = new SelectList(_services, "Id", "Name")
            };

            ViewBag.Success= "پیام شما با موقیت انجام شد";
            return View(model);
        }
      
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
