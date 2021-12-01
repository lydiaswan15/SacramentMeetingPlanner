namespace SacramentMeeting.Models
{
    public class Speaker
    {
        public int SpeakerId { get; set; }
        public string Topic { get; set; }
        public string Name { get; set; }

        public int SacramentPlanId { get; set; }
        public SacramentPlan SacramentPlan { get; set; }
    }
}