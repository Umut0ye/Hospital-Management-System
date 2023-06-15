using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital_Management_System.Models
{
    public class Patient
    {
        public int Id { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }

        [Required]
        [Display(Name = "Ad")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Soyad")]
        public string LastName { get; set; }

        [Display(Name = "Ad")]
        public string FullName { get; set; }

        [EmailAddress]
        [Display(Name = "Eposta Adresi")]
        public string EmailAddress { get; set; }
        [Display(Name = "Telefon Numarası")]
        public string PhoneNo { get; set; }
        public string Contact { get; set; }
        [Display(Name = "Kan Grubu")]
        public string BloodGroup { get; set; }
        public string Gender { get; set; }
        [Display(Name = "Doğum Tarihi")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateOfBirth { get; set; }
        [Display(Name = "Adres")]
        public string Address { get; set; }
    }
}