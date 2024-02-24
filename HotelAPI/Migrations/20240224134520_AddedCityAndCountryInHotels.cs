using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelAPI.Migrations
{
    public partial class AddedCityAndCountryInHotels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: "00b49f65-b472-49a6-bdfc-0890ee1c9f37");

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: "332d0d04-a59e-47e9-b18b-6d140a9f96ad");

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: "4f83789d-d01e-47bb-8c4a-05b0b49c86b1");

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: "907affb9-d69b-4467-a1ad-dbd08e50b215");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "City", "Country", "Name" },
                values: new object[,]
                {
                    { "076fb610-1bac-4fc3-95ce-209d3f8f4d19", "Los Angeles", "United States of America", "Hills" },
                    { "0a1450be-63db-4b04-9ea9-203c1fc60b97", "Nessebar", "Bulgaria", "Nessebar" },
                    { "13f63e52-4837-4b24-931e-504328060ac8", "Sofia", "Bulgaria", "Sofia" },
                    { "62d06c84-668d-4840-b749-02200592909d", "Mexico", "Mexico", "Nexus" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: "076fb610-1bac-4fc3-95ce-209d3f8f4d19");

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: "0a1450be-63db-4b04-9ea9-203c1fc60b97");

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: "13f63e52-4837-4b24-931e-504328060ac8");

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: "62d06c84-668d-4840-b749-02200592909d");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Hotels");

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "00b49f65-b472-49a6-bdfc-0890ee1c9f37", "Sofia" },
                    { "332d0d04-a59e-47e9-b18b-6d140a9f96ad", "Hills" },
                    { "4f83789d-d01e-47bb-8c4a-05b0b49c86b1", "Nessebar" },
                    { "907affb9-d69b-4467-a1ad-dbd08e50b215", "Nexus" }
                });
        }
    }
}
