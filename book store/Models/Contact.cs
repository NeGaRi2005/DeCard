using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Models
{
    public class Contact
    {
      
        [Required(ErrorMessage = "پر کردن این فیلد اجباری هست")]
        public string Name { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "پر کردن این فیلد اجباری هست")]
        public string Massage { get; set; }
        [Required(ErrorMessage = "پر کردن این فیلد اجباری هست")]
        [EmailAddress(ErrorMessage ="مقدار وارد شده صحیح نمیباشد")]
        public string Email{ get; set; }
        public int phone { get; set; }

    }
}
