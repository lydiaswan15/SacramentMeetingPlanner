using System;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace SacramentMeeting.Models
{
    public class SacramentPlan
    {
        public int SacramentPlanId { get; set; }

        public DateTime Date { get; set; }
        public string ConductingLeader { get; set; }

        public string OpenningHymn { get; set; }
        public string ClosingHymn { get; set; }
        public string SacramentHymn { get; set; }
        public string? MusicNumber { get; set; }

        public string OpenningPrayer { get; set; }

        public string ClosingPrayer { get; set; }

        public ICollection<Speaker> Speakers { get; set; }
        public string SpeakerSubject { get; set; }

    }
}