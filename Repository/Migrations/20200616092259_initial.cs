using Microsoft.EntityFrameworkCore.Migrations;
using Oracle.EntityFrameworkCore.Metadata;

namespace QuantityMeasurementRepository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lengths",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    Feet = table.Column<double>(nullable: false),
                    Inch = table.Column<double>(nullable: false),
                    Centimeter = table.Column<double>(nullable: false),
                    Yard = table.Column<double>(nullable: false),
                    OptionType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lengths", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tempretures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    Fahrenhiet = table.Column<double>(nullable: false),
                    Celcius = table.Column<double>(nullable: false),
                    OptionType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tempretures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Volumes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    Litre = table.Column<double>(nullable: false),
                    Gallon = table.Column<double>(nullable: false),
                    Mililitre = table.Column<double>(nullable: false),
                    OptionType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volumes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weights",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    Kilogram = table.Column<double>(nullable: false),
                    Gram = table.Column<double>(nullable: false),
                    Tonee = table.Column<double>(nullable: false),
                    OptionType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weights", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lengths");

            migrationBuilder.DropTable(
                name: "Tempretures");

            migrationBuilder.DropTable(
                name: "Volumes");

            migrationBuilder.DropTable(
                name: "Weights");
        }
    }
}
