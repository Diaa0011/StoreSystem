using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StoreSystem.Migrations
{
    /// <inheritdoc />
    public partial class RemoveSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "stores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "stores",
                keyColumn: "Id",
                keyValue: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Lorem Ipsum", "Samasung S24", 2000m },
                    { 2, "Lorem Ipsum", "Iphone 14", 3000m }
                });

            migrationBuilder.InsertData(
                table: "stores",
                columns: new[] { "Id", "Address", "Latitude", "Longitude", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Ahmed Orabi Square", 0.0, 0.0, "Manshia Store", "0123456789" },
                    { 2, "Front of sidi Gaber Elsheikh tram station", 0.0, 0.0, "Sidi Gaber Store", "0123456789" }
                });
        }
    }
}
