using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Models
{
    public class Project
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description{ get; set; }
        public string Client{ get; set; }
    }
   
    //public class IndexModel
    //{
 
    //    public List<Article> Article { get; set; }
    //    public List<Project> Project { get; set; }
    //}
}
