using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MCV.Migrations
{
    public partial class Seededdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PeopleData",
                columns: new[] { "Id", "City", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { "2b38f403-a45c-42f1-bf84-0abc30e56844", "Göteborg", "Andreas Lyckholm", "0768382888" },
                    { "2c0cf7ed-0b66-47e2-b76e-f831d56d6e0b", "Göteborg", "Christoffer Lyckholm", "0761717777" },
                    { "8b179a3e-b5ca-4dfb-9f82-68da84839f10", "Stockholm", "Sven Svensson", "085676832" },
                    { "cea6c7ba-15c3-419e-b6ac-e0d3a3a29c77", "Stockholm", "Sten Sture", "0808807652" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PeopleData",
                keyColumn: "Id",
                keyValue: "2b38f403-a45c-42f1-bf84-0abc30e56844");

            migrationBuilder.DeleteData(
                table: "PeopleData",
                keyColumn: "Id",
                keyValue: "2c0cf7ed-0b66-47e2-b76e-f831d56d6e0b");

            migrationBuilder.DeleteData(
                table: "PeopleData",
                keyColumn: "Id",
                keyValue: "8b179a3e-b5ca-4dfb-9f82-68da84839f10");

            migrationBuilder.DeleteData(
                table: "PeopleData",
                keyColumn: "Id",
                keyValue: "cea6c7ba-15c3-419e-b6ac-e0d3a3a29c77");
        }
    }
}
