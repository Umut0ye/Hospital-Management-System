using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital_Management_System.Models
{
    public class Ambulance
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Ambulans Kimliği")]
        public string AmbulanceId { get; set; }       
        
        [Display(Name = "Ambulans Durumu")]
        public string AmbulanceStatus { get; set; }
        [Display(Name = "Ambulans Sürücüsü")]
        public AmbulanceDriver AmbulanceDriver { get; set; }
        [Display(Name = "Ambulans Kimliği")]
        public int AmbulanceDriverId { get; set; }
    }
}