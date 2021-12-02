using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class SpellingOnOpeningPrayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OpenningPrayer",
                table: "SacramentPlan",
                newName: "OpeningPrayer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OpeningPrayer",
                table: "SacramentPlan",
                newName: "OpenningPrayer");
        }
    }
}
