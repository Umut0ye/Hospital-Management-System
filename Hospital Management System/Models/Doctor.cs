using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital_Management_System.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }

        public string FullName { get; set; }

        [Required]
        [Display(Name = "Ad")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Soyad")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "eposta")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name = "Atama")]
        public string Designation { get; set; }
        [Display(Name = "Bölüm")]
        public Department Department { get; set; }
        [Display(Name = "Bölüm Numarası")]
        public int DepartmentId { get; set; }
        [Display(Name = "Adres")]
        public string Address { get; set; }
        [Display(Name = "Ev Telefonu")]
        public string PhoneNo { get; set; }

        [Required]
        [Display(Name = "Telefon")]
        public string ContactNo { get; set; }

        [Required]
        [Display(Name = "Uzmanlık")]
        public string Specialization { get; set; }

        [Required]
        [Display(Name = "Cinsiyet")]
        public string Gender { get; set; }

        [Required]
        [Display(Name = "Kan Grubu")]
        public string BloodGroup { get; set; }

        [Display(Name = "Doğum Tarihi")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Eğitim derecesi")]
        public string Education { get; set; }

        [Required]
        [Display(Name = "Durumu")]
        public string Status { get; set; }

    }
}