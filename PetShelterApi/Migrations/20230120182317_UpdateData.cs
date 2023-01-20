using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShelterApi.Migrations
{
    public partial class UpdateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                column: "ShelterDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                column: "ShelterDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                column: "ShelterDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4,
                column: "ShelterDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5,
                column: "ShelterDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6,
                column: "ShelterDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7,
                column: "ShelterDate",
                value: null);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                column: "ShelterDate",
                value: "01/20/2023");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                column: "ShelterDate",
                value: "12/20/2022");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                column: "ShelterDate",
                value: "01/03/2023");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4,
                column: "ShelterDate",
                value: "01/10/2023");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5,
                column: "ShelterDate",
                value: "12/15/2023");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6,
                column: "ShelterDate",
                value: "01/10/2023");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7,
                column: "ShelterDate",
                value: "01/18/2023");
        }
    }
}
