using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BishopricMember",
                columns: table => new
                {
                    BishopricMemberId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BishopricMemberName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BishopricMember", x => x.BishopricMemberId);
                });

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

            migrationBuilder.CreateTable(
                name: "SacramentPlan",
                columns: table => new
                {
                    SacramentPlanId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BishopricMemberId = table.Column<int>(type: "INTEGER", nullable: false),
                    OpeningHymnId = table.Column<int>(type: "INTEGER", nullable: false),
                    ClosingHymnId = table.Column<int>(type: "INTEGER", nullable: false),
                    SacramentHymnId = table.Column<int>(type: "INTEGER", nullable: false),
                    MusicNumber = table.Column<string>(type: "TEXT", nullable: true),
                    OpeningPrayer = table.Column<string>(type: "TEXT", nullable: true),
                    ClosingPrayer = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SacramentPlan", x => x.SacramentPlanId);
                    table.ForeignKey(
                        name: "FK_SacramentPlan_BishopricMember_BishopricMemberId",
                        column: x => x.BishopricMemberId,
                        principalTable: "BishopricMember",
                        principalColumn: "BishopricMemberId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SacramentPlan_Hymn_ClosingHymnId",
                        column: x => x.ClosingHymnId,
                        principalTable: "Hymn",
                        principalColumn: "HymnId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SacramentPlan_Hymn_OpeningHymnId",
                        column: x => x.OpeningHymnId,
                        principalTable: "Hymn",
                        principalColumn: "HymnId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SacramentPlan_Hymn_SacramentHymnId",
                        column: x => x.SacramentHymnId,
                        principalTable: "Hymn",
                        principalColumn: "HymnId",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_SacramentPlan_BishopricMemberId",
                table: "SacramentPlan",
                column: "BishopricMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_SacramentPlan_ClosingHymnId",
                table: "SacramentPlan",
                column: "ClosingHymnId");

            migrationBuilder.CreateIndex(
                name: "IX_SacramentPlan_OpeningHymnId",
                table: "SacramentPlan",
                column: "OpeningHymnId");

            migrationBuilder.CreateIndex(
                name: "IX_SacramentPlan_SacramentHymnId",
                table: "SacramentPlan",
                column: "SacramentHymnId");

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

            migrationBuilder.DropTable(
                name: "BishopricMember");

            migrationBuilder.DropTable(
                name: "Hymn");
        }
    }
}
