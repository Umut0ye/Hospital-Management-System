using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital_Management_System.Models
{
    public class AmbulanceDriver
    {
        public int Id { get; set; }
        [Required]
        public string  Name { get; set; }
        [Required]
        [Display(Name = "Ad")]
        public string Contact { get; set; }
        [Required]
        [Display(Name = "İletişim")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "tc")]
        public string Cnic { get; set; }

    }
}