using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Models
{
    public class Chart
    {
        public Chart(string adress, string title, string small, int ariaValuenow, int ariaValuemin, int ariaValuemax, string span)
        {
            Adress = adress;
            Title = title;
            Small = small;
            AriaValuenow = ariaValuenow;
            AriaValuemin = ariaValuemin;
            AriaValuemax = ariaValuemax;
            Span = span;
        }

        public string Adress{ get; set; }
        public string Title{ get; set; }
        public string Small{ get; set; }
        public int AriaValuenow { get; set; }
        public int AriaValuemin { get; set; }
        public int AriaValuemax { get; set; }
        public  string Span{ get; set; }
       
    }
}
