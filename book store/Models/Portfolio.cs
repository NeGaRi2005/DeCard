using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Models
{
    public class Portfolio
    {
        public Portfolio(string title)
        {
            Title = title;
          
        }

        public String Title { get; set; }
     
    }
}
