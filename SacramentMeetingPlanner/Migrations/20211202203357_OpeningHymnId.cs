using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class OpeningHymnId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SacramentPlan_Hymn_HymnId",
                table: "SacramentPlan");

            migrationBuilder.RenameColumn(
                name: "HymnId",
                table: "SacramentPlan",
                newName: "OpeningHymnId");

            migrationBuilder.RenameIndex(
                name: "IX_SacramentPlan_HymnId",
                table: "SacramentPlan",
                newName: "IX_SacramentPlan_OpeningHymnId");

            migrationBuilder.AddForeignKey(
                name: "FK_SacramentPlan_Hymn_OpeningHymnId",
                table: "SacramentPlan",
                column: "OpeningHymnId",
                principalTable: "Hymn",
                principalColumn: "HymnId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SacramentPlan_Hymn_OpeningHymnId",
                table: "SacramentPlan");

            migrationBuilder.RenameColumn(
                name: "OpeningHymnId",
                table: "SacramentPlan",
                newName: "HymnId");

            migrationBuilder.RenameIndex(
                name: "IX_SacramentPlan_OpeningHymnId",
                table: "SacramentPlan",
                newName: "IX_SacramentPlan_HymnId");

            migrationBuilder.AddForeignKey(
                name: "FK_SacramentPlan_Hymn_HymnId",
                table: "SacramentPlan",
                column: "HymnId",
                principalTable: "Hymn",
                principalColumn: "HymnId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
