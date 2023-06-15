using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital_Management_System.Models
{
    public class Schedule
    {
        public int Id { get; set; }

        public Doctor Doctor { get; set; }
        [Display(Name = "Doktor Adı")]
        public int DoctorId { get; set; }

        [Required]
        [Display(Name = "Başlangıç")]
        public string AvailableStartDay { get; set; }

        [Required]
        [Display(Name = "Bitiş")]
        public string AvailableEndDay { get; set; }

        [Required]
        [Display(Name = "Başlangıç Saati")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime AvailableStartTime { get; set; }

        [Required]
        [Display(Name = "Bitiş Saati")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime AvailableEndTime { get; set; }

        [Required]
        [Display(Name = "Muayene Süresi")]
        public string TimePerPatient { get; set; }

        [Required]
        [Display(Name = "Durumu")]
        public string Status { get; set; }
    }
}