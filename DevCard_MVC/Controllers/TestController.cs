using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            // return new  NotFoundResult();
            return new StatusCodeResult(502);
        }
    }
}
