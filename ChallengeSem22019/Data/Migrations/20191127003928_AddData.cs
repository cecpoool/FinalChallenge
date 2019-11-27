using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChallengeSem22019.Data.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Team1 = table.Column<string>(nullable: true),
                    Team2 = table.Column<string>(nullable: true),
                    Venue = table.Column<string>(nullable: true),
                    TimeOfDate = table.Column<DateTime>(nullable: false),
                    Payer = table.Column<string>(nullable: true),
                    CourtFees = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
