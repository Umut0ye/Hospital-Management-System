using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital_Management_System.Models
{
    public class Complaint
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Şikayet Et")]
        public string Complain { get; set; }
        [Display(Name = "Yanıt Ver")]
        public string Reply { get; set; }
        public DateTime? ComplainDate { get; set; }
    }
}