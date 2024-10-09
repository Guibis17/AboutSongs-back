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
                values: new object[] { "6bf11ded-722a-4ec5-b655-57232b2deb65", "AQAAAAIAAYagAAAAEBOOn41czfMVv3JIZG641sWGaZnSyHyrOT6EDDgO1BFmYKIjKJHUGbQLPxFk4IxskA==", "be329259-1eea-4c78-a852-afd6aaafedee" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b510c3a9-4aac-48e4-ba22-1511167363c8", "AQAAAAIAAYagAAAAEJJAsxrJn2uwLUy4AdjmSwV6VRdcQ3/zzLUjtlZFZPLJyiGsE2dDtdnPC5Js0q3rEA==", "16a0848d-79a9-4e8a-913e-dea42700686b" });
        }
    }
}
