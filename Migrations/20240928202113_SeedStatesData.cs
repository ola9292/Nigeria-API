using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace nigeria.Migrations
{
    /// <inheritdoc />
    public partial class SeedStatesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "Area", "Capital", "Governor", "Name", "Population", "Region" },
                values: new object[,]
                {
                    { 1, 1171.0, "Ikeja", "Babajide Sanwo-Olu", "Lagos", 14210000L, "South-West" },
                    { 2, 20131.0, "Kano", "Abba Kabir Yusuf", "Kano", 11037920L, "North-West" },
                    { 3, 4844.0, "Awka", "Charles Chukwuma Soludo", "Anambra", 5612000L, "South-East" },
                    { 4, 11077.0, "Port Harcourt", "Siminalayi Fubara", "Rivers", 7191000L, "South-South" },
                    { 5, 28454.0, "Ibadan", "Seyi Makinde", "Oyo", 7800000L, "South-West" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
