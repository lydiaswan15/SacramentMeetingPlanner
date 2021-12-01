using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SacramentMeeting.Models;

public class SacramentMeetingPlannerContext : DbContext
{
    public SacramentMeetingPlannerContext(DbContextOptions<SacramentMeetingPlannerContext> options)
        : base(options)
    {
    }

    public DbSet<SacramentMeeting.Models.SacramentPlan> SacramentPlan { get; set; }

    public DbSet<SacramentMeeting.Models.Speaker> Speaker { get; set; }


}
