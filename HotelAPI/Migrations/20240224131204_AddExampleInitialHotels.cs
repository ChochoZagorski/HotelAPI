using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelAPI.Migrations
{
    public partial class AddExampleInitialHotels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
