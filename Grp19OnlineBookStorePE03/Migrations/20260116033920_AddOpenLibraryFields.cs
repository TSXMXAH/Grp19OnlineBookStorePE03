using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Grp19OnlineBookStorePE03.Migrations
{
    /// <inheritdoc />
    public partial class AddOpenLibraryFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BookName",
                table: "Book",
                newName: "Title");

            migrationBuilder.AddColumn<string>(
                name: "CoverUrl",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ISBN",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OpenLibraryWorkKey",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PublishYear",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-4789-8901-234567890abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3a94367-c426-4e8d-bce7-ca9a7ef7ecca", "AQAAAAIAAYagAAAAEH4YM94PKKn8OOy9o0GjLrxNqUtRRvBSoHDrsyqpXXzyZF4zBITbWvo0KvqHYSPFsA==", "b9a13817-b9b3-4cca-880f-294a52f49aad" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoverUrl", "ISBN", "OpenLibraryWorkKey", "PublishYear" },
                values: new object[] { null, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoverUrl", "ISBN", "OpenLibraryWorkKey", "PublishYear" },
                values: new object[] { null, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoverUrl", "ISBN", "OpenLibraryWorkKey", "PublishYear" },
                values: new object[] { null, null, null, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverUrl",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "ISBN",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "OpenLibraryWorkKey",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "PublishYear",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Book",
                newName: "BookName");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1a2b3c4-d5e6-4789-8901-234567890abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25cc7bb2-ea72-4b7e-a622-e6094c552851", "AQAAAAIAAYagAAAAEFlfM47EWwMsaQdcXsR+tFxHUnh+hY+bmvr1riYwmDXmk0QLWUVqFER26aCZHhoEyA==", "663982aa-bfc6-4b90-b779-1c79107528b3" });
        }
    }
}
