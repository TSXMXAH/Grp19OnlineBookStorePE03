using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Grp19OnlineBookStorePE03.Migrations
{
    /// <inheritdoc />
    public partial class AddedBookStockSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookStock",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookStock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookStock_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-4789-8901-234567890abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f76215e9-81e0-4622-a34e-28d92aadb917", "AQAAAAIAAYagAAAAEO9yieCnEZDJJYQH3mZ4ZtrwQMUWA6dplJcYio8lisI5Ekb2t2BPwJebQQUzOyhYBQ==", "2a26b19f-8b63-43a3-92fa-a0e90be479fe" });

            migrationBuilder.InsertData(
                table: "BookStock",
                columns: new[] { "Id", "BookId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 5 },
                    { 2, 2, 3 },
                    { 3, 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookStock_BookId",
                table: "BookStock",
                column: "BookId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookStock");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-4789-8901-234567890abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3a94367-c426-4e8d-bce7-ca9a7ef7ecca", "AQAAAAIAAYagAAAAEH4YM94PKKn8OOy9o0GjLrxNqUtRRvBSoHDrsyqpXXzyZF4zBITbWvo0KvqHYSPFsA==", "b9a13817-b9b3-4cca-880f-294a52f49aad" });
        }
    }
}
