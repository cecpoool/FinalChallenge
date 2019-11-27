using Microsoft.EntityFrameworkCore.Migrations;

namespace ChallengeSem22019.Data.Migrations
{
    public partial class AddedPaidBool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Paid",
                table: "Games",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Paid",
                table: "Games");
        }
    }
}
