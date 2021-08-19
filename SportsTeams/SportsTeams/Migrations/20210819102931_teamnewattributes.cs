using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsTeams.Migrations
{
    public partial class teamnewattributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HeadCoach",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "League",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "President",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StadiumCapacity",
                table: "Teams",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HeadCoach",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "League",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "President",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "StadiumCapacity",
                table: "Teams");
        }
    }
}
