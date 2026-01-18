using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Grp19OnlineBookStorePE03.Migrations
{
    /// <inheritdoc />
    public partial class FixWishlistNullableFKs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WishlistItem_Book_BookId",
                table: "WishlistItem");

            migrationBuilder.DropForeignKey(
                name: "FK_WishlistItem_Misc_MiscId",
                table: "WishlistItem");

            migrationBuilder.AlterColumn<int>(
                name: "MiscId",
                table: "WishlistItem",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "WishlistItem",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-4789-8901-234567890abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a87ea7d-dca6-4d17-b7c7-f11d29b9ff70", "AQAAAAIAAYagAAAAEHhvz6GvG3//DNekSw8Td7a/AayAhONpPNZUhyEpfEgFmMwwH1CLo/6I0g63SVrM3g==", "4c8efe82-594b-4d33-ba4e-33ba89c7a324" });

            migrationBuilder.AddForeignKey(
                name: "FK_WishlistItem_Book_BookId",
                table: "WishlistItem",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WishlistItem_Misc_MiscId",
                table: "WishlistItem",
                column: "MiscId",
                principalTable: "Misc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WishlistItem_Book_BookId",
                table: "WishlistItem");

            migrationBuilder.DropForeignKey(
                name: "FK_WishlistItem_Misc_MiscId",
                table: "WishlistItem");

            migrationBuilder.AlterColumn<int>(
                name: "MiscId",
                table: "WishlistItem",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "WishlistItem",
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
                values: new object[] { "adaf6dee-22d8-4229-a067-5bf953043ade", "AQAAAAIAAYagAAAAEDgDcPD6F8HYuQxmyHoZn446R26Mm/iU1jhSxEJOSUdWN9rgFuWHHEyekLU17w6CbQ==", "134b3b40-a73b-4ffb-ba8a-221687d52b96" });

            migrationBuilder.AddForeignKey(
                name: "FK_WishlistItem_Book_BookId",
                table: "WishlistItem",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WishlistItem_Misc_MiscId",
                table: "WishlistItem",
                column: "MiscId",
                principalTable: "Misc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
