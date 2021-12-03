using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class IntermediateHymn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MusicNumber",
                table: "SacramentPlan");

            migrationBuilder.AddColumn<int>(
                name: "IntermediateHymnId",
                table: "SacramentPlan",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SacramentPlan_IntermediateHymnId",
                table: "SacramentPlan",
                column: "IntermediateHymnId");

            migrationBuilder.AddForeignKey(
                name: "FK_SacramentPlan_Hymn_IntermediateHymnId",
                table: "SacramentPlan",
                column: "IntermediateHymnId",
                principalTable: "Hymn",
                principalColumn: "HymnId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SacramentPlan_Hymn_IntermediateHymnId",
                table: "SacramentPlan");

            migrationBuilder.DropIndex(
                name: "IX_SacramentPlan_IntermediateHymnId",
                table: "SacramentPlan");

            migrationBuilder.DropColumn(
                name: "IntermediateHymnId",
                table: "SacramentPlan");

            migrationBuilder.AddColumn<string>(
                name: "MusicNumber",
                table: "SacramentPlan",
                type: "TEXT",
                nullable: true);
        }
    }
}
