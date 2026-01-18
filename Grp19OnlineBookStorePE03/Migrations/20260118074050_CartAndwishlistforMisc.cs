using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Grp19OnlineBookStorePE03.Migrations
{
    /// <inheritdoc />
    public partial class CartAndwishlistforMisc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Book_BookId",
                table: "CartItem");

            migrationBuilder.AddColumn<int>(
                name: "MiscId",
                table: "WishlistItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "CartItem",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "MiscId",
                table: "CartItem",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-4789-8901-234567890abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adaf6dee-22d8-4229-a067-5bf953043ade", "AQAAAAIAAYagAAAAEDgDcPD6F8HYuQxmyHoZn446R26Mm/iU1jhSxEJOSUdWN9rgFuWHHEyekLU17w6CbQ==", "134b3b40-a73b-4ffb-ba8a-221687d52b96" });

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItem_MiscId",
                table: "WishlistItem",
                column: "MiscId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_MiscId",
                table: "CartItem",
                column: "MiscId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Book_BookId",
                table: "CartItem",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Misc_MiscId",
                table: "CartItem",
                column: "MiscId",
                principalTable: "Misc",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WishlistItem_Misc_MiscId",
                table: "WishlistItem",
                column: "MiscId",
                principalTable: "Misc",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Book_BookId",
                table: "CartItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Misc_MiscId",
                table: "CartItem");

            migrationBuilder.DropForeignKey(
                name: "FK_WishlistItem_Misc_MiscId",
                table: "WishlistItem");

            migrationBuilder.DropIndex(
                name: "IX_WishlistItem_MiscId",
                table: "WishlistItem");

            migrationBuilder.DropIndex(
                name: "IX_CartItem_MiscId",
                table: "CartItem");

            migrationBuilder.DropColumn(
                name: "MiscId",
                table: "WishlistItem");

            migrationBuilder.DropColumn(
                name: "MiscId",
                table: "CartItem");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "CartItem",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-4789-8901-234567890abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ef1933b-3ff4-4230-b829-c5ae31c86386", "AQAAAAIAAYagAAAAEGtXGAfDRqCqKGY6w7DlDSDwWHBBBjKEciJTLvLZ3hhR5n53PCdkw4MsicHFRXftoA==", "8b20df5a-11ed-4190-b2f3-e35a6fa06c53" });

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Book_BookId",
                table: "CartItem",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
