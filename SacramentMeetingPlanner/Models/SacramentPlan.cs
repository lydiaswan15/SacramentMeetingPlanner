using System;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace SacramentMeeting.Models
{
    public class SacramentPlan
    {
        public int SacramentPlanId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:D}", ApplyFormatInEditMode = false)]
        public DateTime Date { get; set; }
        [Display(Name = "Conducting")]
        public string ConductingLeader { get; set; }
        [Display(Name = "Opening Hymn")]

        public int OpeningHymnId { get; set; }
        public Hymn OpeningHymn { get; set; }
        [Display(Name = "Closing Hymn")]
        public int ClosingHymnId { get; set; }
        public Hymn ClosingHymn { get; set; }
        [Display(Name = "Sacrament Hymn")]

        public int SacramentHymnId { get; set; }
        public Hymn SacramentHymn { get; set; }
        [Display(Name = "Intermediate Hymn")]
        public string? MusicNumber { get; set; }
        [Display(Name = "Opening Prayer")]
        public string OpeningPrayer { get; set; }
        [Display(Name = "Closing Prayer")]
        public string ClosingPrayer { get; set; }

        public ICollection<Speaker> Speakers { get; set; }

    }
}