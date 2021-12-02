using System;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace SacramentMeeting.Models
{
    public class SacramentPlan
    {
        public int SacramentPlanId { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        [Display(Name = "Conducting")]
        public string ConductingLeader { get; set; }
        [Display(Name = "Opening Hymn")]
        public string OpenningHymn { get; set; }
        [Display(Name = "Closing Hymn")]
        public string ClosingHymn { get; set; }
        [Display(Name = "Sacrament Hymn")]
        public string SacramentHymn { get; set; }
        [Display(Name = "Intermediate Hymn")]
        public string? MusicNumber { get; set; }
        [Display(Name = "Opening Prayer")]
        public string OpenningPrayer { get; set; }
        [Display(Name = "Closing Prayer")]
        public string ClosingPrayer { get; set; }

        public ICollection<Speaker> Speakers { get; set; }

    }
}