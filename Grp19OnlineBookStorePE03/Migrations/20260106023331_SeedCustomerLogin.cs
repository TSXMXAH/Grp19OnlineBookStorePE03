using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Grp19OnlineBookStorePE03.Migrations
{
    /// <inheritdoc />
    public partial class SeedCustomerLogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Login", "Password" },
                values: new object[] { "sarah123", "password123" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Login", "Password" },
                values: new object[] { null, null });
        }
    }
}
