using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InSaideResturant.Migrations
{
    public partial class changepay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ISpay",
                table: "paymoney");

            migrationBuilder.AddColumn<bool>(
                name: "IsPayment",
                table: "reservation",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPayment",
                table: "reservation");

            migrationBuilder.AddColumn<bool>(
                name: "ISpay",
                table: "paymoney",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
