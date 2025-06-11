using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TinderForDogs.Migrations
{
    /// <inheritdoc />
    public partial class SeedDogs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Age", "Bio", "Breed", "Gender", "Name", "OwnerId" },
                values: new object[,]
                {
                    { 1, 3, "Loves to play fetch!", "Golden Retriever", "Male", "Mirel", 1 },
                    { 2, 2, "Enjoys swimming.", "Labrador", "Female", "Maria", 1 },
                    { 3, 4, "Short legs, big heart.", "Corgi", "Male", "Nefor", 1 },
                    { 4, 5, "Very smart and friendly.", "Poodle", "Female", "Olmanei", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
