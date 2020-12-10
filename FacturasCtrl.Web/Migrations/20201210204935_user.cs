using Microsoft.EntityFrameworkCore.Migrations;

namespace FacturasCtrl.Web.Migrations
{
    public partial class user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "MyPersonals");

            migrationBuilder.DropColumn(
                name: "CellPhone",
                table: "MyPersonals");

            migrationBuilder.DropColumn(
                name: "Document",
                table: "MyPersonals");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "MyPersonals");

            migrationBuilder.DropColumn(
                name: "FixedPhone",
                table: "MyPersonals");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "MyPersonals");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "MyPersonals",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CellPhone",
                table: "MyPersonals",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Document",
                table: "MyPersonals",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "MyPersonals",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FixedPhone",
                table: "MyPersonals",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "MyPersonals",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
