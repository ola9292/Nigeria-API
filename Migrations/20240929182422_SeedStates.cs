using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace nigeria.Migrations
{
    /// <inheritdoc />
    public partial class SeedStates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "Area", "Capital", "Governor", "Name", "Population", "Region" },
                values: new object[,]
                {
                    { 6, 6320.0, "Umuahia", "Okezie Ikpeazu", "Abia", 3643000L, "South-East" },
                    { 7, 36917.0, "Yola", "Ahmadu Umaru Fintiri", "Adamawa", 4485000L, "North-East" },
                    { 8, 7081.0, "Uyo", "Umo Eno", "Akwa Ibom", 5540000L, "South-South" },
                    { 9, 4844.0, "Awka", "Charles Chukwuma Soludo", "Anambra", 5612000L, "South-East" },
                    { 10, 45837.0, "Bauchi", "Bala Mohammed", "Bauchi", 6555000L, "North-East" },
                    { 11, 10773.0, "Yenagoa", "Douye Diri", "Bayelsa", 2325000L, "South-South" },
                    { 12, 34059.0, "Makurdi", "Hyacinth Alia", "Benue", 5339000L, "North-Central" },
                    { 13, 70698.0, "Maiduguri", "Babagana Umara Zulum", "Borno", 5883000L, "North-East" },
                    { 14, 20156.0, "Calabar", "Bassey Otu", "Cross River", 3785000L, "South-South" },
                    { 15, 17898.0, "Asaba", "Sheriff Oborevwori", "Delta", 5714000L, "South-South" },
                    { 16, 5533.0, "Abakaliki", "Francis Nwifuru", "Ebonyi", 2905000L, "South-East" },
                    { 17, 17802.0, "Benin City", "Godwin Obaseki", "Edo", 4705000L, "South-South" },
                    { 18, 6353.0, "Ado Ekiti", "Biodun Oyebanji", "Ekiti", 3314000L, "South-West" },
                    { 19, 7161.0, "Enugu", "Peter Mbah", "Enugu", 4354000L, "South-East" },
                    { 20, 18768.0, "Gombe", "Inuwa Yahaya", "Gombe", 3102000L, "North-East" },
                    { 21, 5530.0, "Owerri", "Hope Uzodinma", "Imo", 5410000L, "South-East" },
                    { 22, 23154.0, "Dutse", "Umar Namadi", "Jigawa", 5533000L, "North-West" },
                    { 23, 46053.0, "Kaduna", "Uba Sani", "Kaduna", 8117000L, "North-West" },
                    { 24, 24192.0, "Katsina", "Dikko Radda", "Katsina", 8418000L, "North-West" },
                    { 25, 36800.0, "Birnin Kebbi", "Nasir Idris", "Kebbi", 4418000L, "North-West" },
                    { 26, 29333.0, "Lokoja", "Yahaya Bello", "Kogi", 4388000L, "North-Central" },
                    { 27, 36825.0, "Ilorin", "AbdulRahman AbdulRazaq", "Kwara", 3361000L, "North-Central" },
                    { 28, 27117.0, "Lafia", "Abdullahi Sule", "Nasarawa", 2438000L, "North-Central" },
                    { 29, 76363.0, "Minna", "Mohammed Umaru Bago", "Niger", 5384000L, "North-Central" },
                    { 30, 16762.0, "Abeokuta", "Dapo Abiodun", "Ogun", 4968000L, "South-West" },
                    { 31, 15500.0, "Akure", "Rotimi Akeredolu", "Ondo", 4733000L, "South-West" },
                    { 32, 9251.0, "Oshogbo", "Ademola Adeleke", "Osun", 4202000L, "South-West" },
                    { 33, 30609.0, "Jos", "Caleb Mutfwang", "Plateau", 4823000L, "North-Central" },
                    { 34, 25832.0, "Sokoto", "Ahmed Aliyu", "Sokoto", 5106000L, "North-West" },
                    { 35, 54473.0, "Jalingo", "Agbu Kefas", "Taraba", 3386000L, "North-East" },
                    { 36, 45863.0, "Damaturu", "Mai Mala Buni", "Yobe", 2922000L, "North-East" },
                    { 37, 39262.0, "Gusau", "Dauda Lawal", "Zamfara", 4876000L, "North-West" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 37);
        }
    }
}
