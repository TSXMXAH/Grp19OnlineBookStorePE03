using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Grp19OnlineBookStorePE03.Migrations
{
    /// <inheritdoc />
    public partial class FixCartItemKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CartItem",
                newName: "CartItemId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "CartItem",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-4789-8901-234567890abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1821993d-d234-4789-ac16-91e8bfb25955", "AQAAAAIAAYagAAAAEN4fQpPUVEs7+0u6tcrWZETtS+xy7YtfWKheK1NggKfwWAsHAMu7EJpLMgGypN9uEA==", "eeef22b9-8ac3-444d-b83f-f1f85c436f27" });

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_UserId",
                table: "CartItem",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_AspNetUsers_UserId",
                table: "CartItem",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_AspNetUsers_UserId",
                table: "CartItem");

            migrationBuilder.DropIndex(
                name: "IX_CartItem_UserId",
                table: "CartItem");

            migrationBuilder.RenameColumn(
                name: "CartItemId",
                table: "CartItem",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "CartItem",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-4789-8901-234567890abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8dded482-ee08-4ab5-ad53-fb09cd25de97", "AQAAAAIAAYagAAAAELrc6ZPcDR3ex3Bou+IDnTpFmVeJ4TGbd/HAkidPVEDJiR/oBQsz6aKS15hKxmEB7g==", "ddb1c774-3855-4b7a-addb-a6be3bc863d0" });
        }
    }
}
