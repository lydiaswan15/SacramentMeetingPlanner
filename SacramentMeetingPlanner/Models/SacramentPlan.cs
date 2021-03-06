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


        public int BishopricMemberId { get; set; }
        [Display(Name = "Conducting")]
        public BishopricMember BishopricMember { get; set; }
        public int OpeningHymnId { get; set; }
        [Display(Name = "Opening Hymn")]
        public Hymn OpeningHymn { get; set; }
        [Display(Name = "Closing Hymn")]
        public int ClosingHymnId { get; set; }
        [Display(Name = "Closing Hymn")]
        public Hymn ClosingHymn { get; set; }
        [Display(Name = "Sacrament Hymn")]
        public int SacramentHymnId { get; set; }
        [Display(Name = "Sacrament Hymn")]
        public Hymn SacramentHymn { get; set; }
        [Display(Name = "Intermediate Hymn")]
        public int? IntermediateHymnId { get; set; }
        [Display(Name = "Intermediate Hymn")]
        public Hymn IntermediateHymn { get; set; }
        [Display(Name = "Opening Prayer")]
        public string OpeningPrayer { get; set; }
        [Display(Name = "Closing Prayer")]
        public string ClosingPrayer { get; set; }

        public ICollection<Speaker> Speakers { get; set; }

    }
}