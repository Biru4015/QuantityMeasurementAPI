using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuantityModelLayer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Temperature",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CELSIUS = table.Column<decimal>(unicode: false, nullable: false),
                    FAHRENHEIT = table.Column<decimal>(unicode: false, nullable: false),
                    RESULT = table.Column<decimal>(unicode: false, nullable: false),
                    OPTIONTYPE = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temperature", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Unit",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FEET = table.Column<decimal>(unicode: false, nullable: false),
                    INCH = table.Column<decimal>(unicode: false, nullable: false),
                    YARD = table.Column<decimal>(unicode: false, nullable: false),
                    RESULT = table.Column<decimal>(unicode: false, nullable: false),
                    OPTIONTYPE = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Volume",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GALLON = table.Column<decimal>(unicode: false, nullable: false),
                    LITRE = table.Column<decimal>(unicode: false, nullable: false),
                    MILLILITRE = table.Column<decimal>(unicode: false, nullable: false),
                    RESULT = table.Column<decimal>(unicode: false, nullable: false),
                    OPTIONTYPE = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volume", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Weight",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KG = table.Column<decimal>(unicode: false, nullable: false),
                    GRAM = table.Column<decimal>(unicode: false, nullable: false),
                    TON = table.Column<decimal>(unicode: false, nullable: false),
                    RESULT = table.Column<decimal>(unicode: false, nullable: false),
                    OPTIONTYPE = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weight", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Temperature");

            migrationBuilder.DropTable(
                name: "Unit");

            migrationBuilder.DropTable(
                name: "Volume");

            migrationBuilder.DropTable(
                name: "Weight");
        }
    }
}
