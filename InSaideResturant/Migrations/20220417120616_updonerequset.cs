using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InSaideResturant.Migrations
{
    public partial class updonerequset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ISDone",
                table: "reservation");

            migrationBuilder.AddColumn<bool>(
                name: "ISDone",
                table: "dishrequired",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ISDone",
                table: "dishrequired");

            migrationBuilder.AddColumn<bool>(
                name: "ISDone",
                table: "reservation",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
