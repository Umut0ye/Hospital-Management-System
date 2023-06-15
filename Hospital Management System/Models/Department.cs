using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital_Management_System.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Ad")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Özellikler")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Durum")]
        public string Status { get; set; }
    }
}