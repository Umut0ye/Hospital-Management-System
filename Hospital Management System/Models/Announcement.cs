using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital_Management_System.Models
{
    public class Announcement
    {
        public int  Id { get; set; }
        [Required]
        [Display(Name = "Duyurular")]
        public string Announcements { get; set; }
        [Required]
        [Display(Name = "Duyurular")]
        public string AnnouncementFor { get; set; }
        [Display(Name = "Bitiş Tarihi")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? End { get; set; }

    }
}