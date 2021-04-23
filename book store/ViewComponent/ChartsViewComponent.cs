using book_store.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace book_store
{
    public class ChartsViewComponent :ViewComponent
    {
       

        public IViewComponentResult Invoke()
        {
            var chart = new List<Chart>
            {
               new Chart(" https://modireforosh.ir/best-science-books/","کتاب های علمی","90%",90,0,90,"90% Complete"),
               new Chart("https://www.fadakbook.ir/","کتاب های دانشگاهی","100%",100,0,100,"100% Complete"),
               new Chart("https://www.gajmarket.com","کتاب های درسی و کنکوری","85%",85,0,85,"85% Complete"),
               new Chart("https://jangal.com/","کتاب های خارجی","60%",60,0,60,"60% Complete"),
               new Chart("https://www.banasher.com/","کتاب داستان و رمان ها","70%",70,0,70,"70% Complete")

            };
            return View("_charts",chart);

        }
    }
   
}
