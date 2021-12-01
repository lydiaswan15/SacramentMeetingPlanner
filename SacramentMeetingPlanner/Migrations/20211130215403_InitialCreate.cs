using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SacramentPlan",
                columns: table => new
                {
                    SacramentPlanId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConductingLeader = table.Column<string>(type: "TEXT", nullable: true),
                    OpenningHymn = table.Column<string>(type: "TEXT", nullable: true),
                    ClosingHymn = table.Column<string>(type: "TEXT", nullable: true),
                    SacramentHymn = table.Column<string>(type: "TEXT", nullable: true),
                    MusicNumber = table.Column<string>(type: "TEXT", nullable: true),
                    OpenningPrayer = table.Column<string>(type: "TEXT", nullable: true),
                    ClosingPrayer = table.Column<string>(type: "TEXT", nullable: true),
                    SpeakerSubject = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SacramentPlan", x => x.SacramentPlanId);
                });

            migrationBuilder.CreateTable(
                name: "Speaker",
                columns: table => new
                {
                    SpeakerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Topic = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    SacramentPlanId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speaker", x => x.SpeakerId);
                    table.ForeignKey(
                        name: "FK_Speaker_SacramentPlan_SacramentPlanId",
                        column: x => x.SacramentPlanId,
                        principalTable: "SacramentPlan",
                        principalColumn: "SacramentPlanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Speaker_SacramentPlanId",
                table: "Speaker",
                column: "SacramentPlanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speaker");

            migrationBuilder.DropTable(
                name: "SacramentPlan");
        }
    }
}
