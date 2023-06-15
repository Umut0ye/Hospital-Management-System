using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Hospital_Management_System.Models
{
    public class DepartmentStatus
    {
        [Display(Name = "Ad")]
        public string Name { get; set; }
    }
}