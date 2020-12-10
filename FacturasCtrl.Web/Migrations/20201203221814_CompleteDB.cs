using Microsoft.EntityFrameworkCore.Migrations;

namespace FacturasCtrl.Web.Migrations
{
    public partial class CompleteDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proveedors_Ciudades_CiudadId",
                table: "Proveedors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ciudades",
                table: "Ciudades");

            migrationBuilder.RenameTable(
                name: "Ciudades",
                newName: "Ciudads");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ciudads",
                table: "Ciudads",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Proveedors_Ciudads_CiudadId",
                table: "Proveedors",
                column: "CiudadId",
                principalTable: "Ciudads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proveedors_Ciudads_CiudadId",
                table: "Proveedors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ciudads",
                table: "Ciudads");

            migrationBuilder.RenameTable(
                name: "Ciudads",
                newName: "Ciudades");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ciudades",
                table: "Ciudades",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Proveedors_Ciudades_CiudadId",
                table: "Proveedors",
                column: "CiudadId",
                principalTable: "Ciudades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
