using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class UpdatingHymnsToModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClosingHymn",
                table: "SacramentPlan");

            migrationBuilder.DropColumn(
                name: "SacramentHymn",
                table: "SacramentPlan");

            migrationBuilder.AddColumn<int>(
                name: "ClosingHymnId",
                table: "SacramentPlan",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SacramentHymnId",
                table: "SacramentPlan",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SacramentPlan_ClosingHymnId",
                table: "SacramentPlan",
                column: "ClosingHymnId");

            migrationBuilder.CreateIndex(
                name: "IX_SacramentPlan_SacramentHymnId",
                table: "SacramentPlan",
                column: "SacramentHymnId");

            migrationBuilder.AddForeignKey(
                name: "FK_SacramentPlan_Hymn_ClosingHymnId",
                table: "SacramentPlan",
                column: "ClosingHymnId",
                principalTable: "Hymn",
                principalColumn: "HymnId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SacramentPlan_Hymn_SacramentHymnId",
                table: "SacramentPlan",
                column: "SacramentHymnId",
                principalTable: "Hymn",
                principalColumn: "HymnId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SacramentPlan_Hymn_ClosingHymnId",
                table: "SacramentPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_SacramentPlan_Hymn_SacramentHymnId",
                table: "SacramentPlan");

            migrationBuilder.DropIndex(
                name: "IX_SacramentPlan_ClosingHymnId",
                table: "SacramentPlan");

            migrationBuilder.DropIndex(
                name: "IX_SacramentPlan_SacramentHymnId",
                table: "SacramentPlan");

            migrationBuilder.DropColumn(
                name: "ClosingHymnId",
                table: "SacramentPlan");

            migrationBuilder.DropColumn(
                name: "SacramentHymnId",
                table: "SacramentPlan");

            migrationBuilder.AddColumn<string>(
                name: "ClosingHymn",
                table: "SacramentPlan",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SacramentHymn",
                table: "SacramentPlan",
                type: "TEXT",
                nullable: true);
        }
    }
}
