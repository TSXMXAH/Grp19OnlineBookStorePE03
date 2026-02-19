using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Grp19OnlineBookStorePE03.Migrations
{
    /// <inheritdoc />
    public partial class Payment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-4789-8901-234567890abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcfaad18-183e-4a74-a6e4-fce9b40fcb0f", "AQAAAAIAAYagAAAAEBE+bvELwNxH819rQH9nuHwlKiO/DYVltgNl3Q2G4svh5hIxLEpY3nGTvmn2v5DNyQ==", "cb9c3d24-1b43-4c13-a09a-7bd6847db4f8" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Payment");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-4789-8901-234567890abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afe2dc96-f24f-4934-934c-4c6c357a58c5", "AQAAAAIAAYagAAAAEEjz+eOb9GQun956wDr/Z8igJMr+P0Ru6TgypKK2z49+17W2xdzISnofuERdUIJTug==", "035c2392-a7cf-4a3b-9b9c-be75c4eba880" });
        }
    }
}
