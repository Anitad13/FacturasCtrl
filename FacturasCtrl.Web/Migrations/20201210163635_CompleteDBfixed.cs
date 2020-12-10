using Microsoft.EntityFrameworkCore.Migrations;

namespace FacturasCtrl.Web.Migrations
{
    public partial class CompleteDBfixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tipodocums_Facturas_FacturaId",
                table: "Tipodocums");

            migrationBuilder.DropIndex(
                name: "IX_Tipodocums_FacturaId",
                table: "Tipodocums");

            migrationBuilder.DropColumn(
                name: "FacturaId",
                table: "Tipodocums");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "MyPersonals",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Proveedors_TipoDocumId",
                table: "Proveedors",
                column: "TipoDocumId");

            migrationBuilder.CreateIndex(
                name: "IX_MyPersonals_UserId",
                table: "MyPersonals",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_MyPersonals_AspNetUsers_UserId",
                table: "MyPersonals",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Proveedors_Tipodocums_TipoDocumId",
                table: "Proveedors",
                column: "TipoDocumId",
                principalTable: "Tipodocums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyPersonals_AspNetUsers_UserId",
                table: "MyPersonals");

            migrationBuilder.DropForeignKey(
                name: "FK_Proveedors_Tipodocums_TipoDocumId",
                table: "Proveedors");

            migrationBuilder.DropIndex(
                name: "IX_Proveedors_TipoDocumId",
                table: "Proveedors");

            migrationBuilder.DropIndex(
                name: "IX_MyPersonals_UserId",
                table: "MyPersonals");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "MyPersonals");

            migrationBuilder.AddColumn<int>(
                name: "FacturaId",
                table: "Tipodocums",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tipodocums_FacturaId",
                table: "Tipodocums",
                column: "FacturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tipodocums_Facturas_FacturaId",
                table: "Tipodocums",
                column: "FacturaId",
                principalTable: "Facturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
