using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelAPI.Migrations
{
    public partial class InitialGuest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "City", "Country", "Name" },
                values: new object[,]
                {
                    { "0646e403-6c13-47e8-bed4-ab9146bbefae", "Mexico", "Mexico", "Nexus" },
                    { "104534a5-a298-40a5-b839-e3339182e0a5", "Sofia", "Bulgaria", "Sofia" },
                    { "1560779e-27f2-45b2-9c4f-35f803d73440", "Nessebar", "Bulgaria", "Nessebar" },
                    { "e2bec708-3cdc-4206-84f5-59bbafcd9212", "Los Angeles", "United States of America", "Hills" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: "0646e403-6c13-47e8-bed4-ab9146bbefae");

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: "104534a5-a298-40a5-b839-e3339182e0a5");

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: "1560779e-27f2-45b2-9c4f-35f803d73440");

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: "e2bec708-3cdc-4206-84f5-59bbafcd9212");

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
    }
}
