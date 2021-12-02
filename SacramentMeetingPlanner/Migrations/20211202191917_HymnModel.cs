using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class HymnModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OpenningHymn",
                table: "SacramentPlan");

            migrationBuilder.AddColumn<int>(
                name: "HymnId",
                table: "SacramentPlan",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Hymn",
                columns: table => new
                {
                    HymnId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HymnNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    HymnName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hymn", x => x.HymnId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SacramentPlan_HymnId",
                table: "SacramentPlan",
                column: "HymnId");

            migrationBuilder.AddForeignKey(
                name: "FK_SacramentPlan_Hymn_HymnId",
                table: "SacramentPlan",
                column: "HymnId",
                principalTable: "Hymn",
                principalColumn: "HymnId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SacramentPlan_Hymn_HymnId",
                table: "SacramentPlan");

            migrationBuilder.DropTable(
                name: "Hymn");

            migrationBuilder.DropIndex(
                name: "IX_SacramentPlan_HymnId",
                table: "SacramentPlan");

            migrationBuilder.DropColumn(
                name: "HymnId",
                table: "SacramentPlan");

            migrationBuilder.AddColumn<string>(
                name: "OpenningHymn",
                table: "SacramentPlan",
                type: "TEXT",
                nullable: true);
        }
    }
}
