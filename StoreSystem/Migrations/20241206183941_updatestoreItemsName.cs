using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreSystem.Migrations
{
    /// <inheritdoc />
    public partial class updatestoreItemsName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_soreItem_items_itemId",
                table: "soreItem");

            migrationBuilder.DropForeignKey(
                name: "FK_soreItem_stores_StoreId",
                table: "soreItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_soreItem",
                table: "soreItem");

            migrationBuilder.RenameTable(
                name: "soreItem",
                newName: "storeItems");

            migrationBuilder.RenameIndex(
                name: "IX_soreItem_StoreId",
                table: "storeItems",
                newName: "IX_storeItems_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_soreItem_itemId",
                table: "storeItems",
                newName: "IX_storeItems_itemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_storeItems",
                table: "storeItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_storeItems_items_itemId",
                table: "storeItems",
                column: "itemId",
                principalTable: "items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_storeItems_stores_StoreId",
                table: "storeItems",
                column: "StoreId",
                principalTable: "stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_storeItems_items_itemId",
                table: "storeItems");

            migrationBuilder.DropForeignKey(
                name: "FK_storeItems_stores_StoreId",
                table: "storeItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_storeItems",
                table: "storeItems");

            migrationBuilder.RenameTable(
                name: "storeItems",
                newName: "soreItem");

            migrationBuilder.RenameIndex(
                name: "IX_storeItems_StoreId",
                table: "soreItem",
                newName: "IX_soreItem_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_storeItems_itemId",
                table: "soreItem",
                newName: "IX_soreItem_itemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_soreItem",
                table: "soreItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_soreItem_items_itemId",
                table: "soreItem",
                column: "itemId",
                principalTable: "items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_soreItem_stores_StoreId",
                table: "soreItem",
                column: "StoreId",
                principalTable: "stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
