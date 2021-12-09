using System;
using System.ComponentModel.DataAnnotations;

namespace SacramentMeeting.Models
{
    public class BishopricMember
    {
        [Display(Name = "Conducting")]
        public int BishopricMemberId { get; set; }
        public string BishopricMemberName { get; set; }
    }
}