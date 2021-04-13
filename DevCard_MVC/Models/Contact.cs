using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_MVC.Models
{
    public class Contact
    {
     [EmailAddress (ErrorMessage ="ایمیل وارد شده صحیح نمی باشد")]
        public string Email { get; set; }
        [Required(ErrorMessage ="پر کردن این فیلد اجباری هست")]
        public string Name { get; set; }
        public int Service { get; set; }
        [MaxLength(ErrorMessage =" 100 است حداکثر کاراکتر ")]
        public string Message { get; set; }
      
    }
}