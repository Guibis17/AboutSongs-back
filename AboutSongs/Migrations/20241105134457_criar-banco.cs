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
                values: new object[] { "7e526d53-12c5-4868-a2b1-48e922b54c2d", "AQAAAAIAAYagAAAAEL4/AbvIsBfHIJKHLzSIsb2wo/c1M/FmT0yZQRK1ZbOBxvTr6UE2BlM3M/TAxvPckw==", "cea824a6-1d2f-4e99-8921-331c462ba68d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b68b286a-df15-400b-9c99-c43be7f634c3", "AQAAAAIAAYagAAAAEDT/JopUagtLojHu77iBawctpvDKM2VdGJezWRQJgLCWtYKeD6+nLh4yMqDfXGpHrA==", "afd3ad80-38ab-4b75-89ce-3e283a60454d" });
        }
    }
}
