using Microsoft.EntityFrameworkCore.Migrations;

namespace QuantityModelLayer.Migrations
{
    public partial class migab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Unit",
                table: "Unit");

            migrationBuilder.RenameTable(
                name: "Unit",
                newName: "Length");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Length",
                table: "Length",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Length",
                table: "Length");

            migrationBuilder.RenameTable(
                name: "Length",
                newName: "Unit");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Unit",
                table: "Unit",
                column: "ID");
        }
    }
}
