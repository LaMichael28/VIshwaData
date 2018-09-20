using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class vishwa
    {
        [Display(Name = "Name")]
        public String name { get; set; }

        [Display(Name = "Bhale")]
        public String bhale { get; set; } 
        
    }
}