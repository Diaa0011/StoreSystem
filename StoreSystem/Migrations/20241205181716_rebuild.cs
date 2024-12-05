using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StoreSystem.Migrations
{
    /// <inheritdoc />
    public partial class rebuild : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "stores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "soreItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    itemId = table.Column<int>(type: "int", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_soreItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_soreItem_items_itemId",
                        column: x => x.itemId,
                        principalTable: "items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_soreItem_stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "Id", "Address", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Ahmed Orabi Square", "Manshia Store", "0123456789" },
                    { 2, "Front of sidi Gaber Elsheikh tram station", "Sidi Gaber Store", "0123456789" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_soreItem_itemId",
                table: "soreItem",
                column: "itemId");

            migrationBuilder.CreateIndex(
                name: "IX_soreItem_StoreId",
                table: "soreItem",
                column: "StoreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "soreItem");

            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropTable(
                name: "stores");
        }
    }
}
