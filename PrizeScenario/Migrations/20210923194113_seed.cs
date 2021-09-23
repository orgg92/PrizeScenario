using Microsoft.EntityFrameworkCore.Migrations;

namespace PrizeScenario.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Participants",
                columns: new[] { "UserId", "FirstName", "LastName", "PostCode" },
                values: new object[] { 1, "John", "Doe", "T35710" });

            migrationBuilder.InsertData(
                table: "Participants",
                columns: new[] { "UserId", "FirstName", "LastName", "PostCode" },
                values: new object[] { 2, "Jane", "Doe", "T35711" });

            migrationBuilder.InsertData(
                table: "Participants",
                columns: new[] { "UserId", "FirstName", "LastName", "PostCode" },
                values: new object[] { 3, "Joe", "Smith", "T35710" });

            migrationBuilder.InsertData(
                table: "Participants",
                columns: new[] { "UserId", "FirstName", "LastName", "PostCode" },
                values: new object[] { 4, "Jane", "Smith", "T35710" });

            migrationBuilder.InsertData(
                table: "Participants",
                columns: new[] { "UserId", "FirstName", "LastName", "PostCode" },
                values: new object[] { 5, "Sam", "Fisher", "T35710" });

            migrationBuilder.InsertData(
                table: "Participants",
                columns: new[] { "UserId", "FirstName", "LastName", "PostCode" },
                values: new object[] { 6, "Wonder", "Woman", "T35710" });

            migrationBuilder.InsertData(
                table: "Participants",
                columns: new[] { "UserId", "FirstName", "LastName", "PostCode" },
                values: new object[] { 7, "Patrick", "Star", "T35710" });

            migrationBuilder.InsertData(
                table: "Participants",
                columns: new[] { "UserId", "FirstName", "LastName", "PostCode" },
                values: new object[] { 8, "Patrick", "Stewart", "T35710" });

            migrationBuilder.InsertData(
                table: "Participants",
                columns: new[] { "UserId", "FirstName", "LastName", "PostCode" },
                values: new object[] { 9, "Spongebob", "Squarepants", "T35710" });

            migrationBuilder.InsertData(
                table: "Participants",
                columns: new[] { "UserId", "FirstName", "LastName", "PostCode" },
                values: new object[] { 10, "Pete", "Armstrong", "T35710" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "UserId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "UserId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "UserId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "UserId",
                keyValue: 10);
        }
    }
}
