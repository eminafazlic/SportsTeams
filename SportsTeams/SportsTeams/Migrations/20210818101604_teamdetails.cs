using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsTeams.Migrations
{
    public partial class teamdetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Founded",
                table: "Teams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "HomeGround",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MarketValue",
                table: "Teams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfPlayers",
                table: "Teams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Capital",
                table: "Countries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Population",
                table: "Countries",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Founded",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "HomeGround",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "MarketValue",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "NumberOfPlayers",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Capital",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "Population",
                table: "Countries");
        }
    }
}
