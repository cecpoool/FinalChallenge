using Microsoft.EntityFrameworkCore.Migrations;

namespace ChallengeSem22019.Data.Migrations
{
    public partial class DATAtY : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "CourtFees",
                table: "Games",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "CourtFees",
                table: "Games",
                type: "real",
                nullable: true,
                oldClrType: typeof(decimal));
        }
    }
}
