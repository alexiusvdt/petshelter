using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShelterApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Species = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SubSpecies = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    ShelterDate = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Name", "ShelterDate", "Species", "SubSpecies" },
                values: new object[,]
                {
                    { 1, 7, "Denna", "01/20/2023", "Cat", "Himalayan" },
                    { 2, 2, "Kvothe", "12/20/2022", "Dog", "Borzoi" },
                    { 3, 5, "Haliax", "01/03/2023", "Dog", "Poodle" },
                    { 4, 5, "Bast", "01/10/2023", "Cat", "Domestic Shorthair" },
                    { 5, 10, "OreSeur", "12/15/2023", "Dog", "Wolfhound" },
                    { 6, 4, "Elend", "01/10/2023", "Dog", "Jack Russel Terrier" },
                    { 7, 3, "Kjelvin", "01/18/2023", "Cat", "Abyssinian" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
