using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AboutSongs.Migrations
{
    /// <inheritdoc />
    public partial class criarbanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ea76d04-916c-4431-972d-67411915245f", "AQAAAAIAAYagAAAAEE7Z/C6lZlYogBRT3wtVIsPlU641dRoqy2XAwd30hG6bnrrZ/+UL+haqHX2oayFVeQ==", "5ef257c9-1dee-4790-a21f-67ba2da536cf" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23549069-0577-4d8a-860a-f8c668c841ea", "AQAAAAIAAYagAAAAEPZgh26I5rKLAC3WTY60yLVWj8M0bFeUyTjIpIxiFOrcglWzZQM9yQJmOY9X2RjYvA==", "892a243f-4237-4999-b437-8cdbe050e2f0" });
        }
    }
}
