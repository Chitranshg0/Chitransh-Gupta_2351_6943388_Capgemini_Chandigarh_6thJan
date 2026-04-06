using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHealthcare.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 4, 3, 4, 55, 26, 151, DateTimeKind.Utc).AddTicks(770), "$2a$11$/G9JcJzQz9ihoisqWmlVguNlk0kOIDIfLedgS6ZmhrMc8wKzjz2QW" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 4, 2, 12, 19, 44, 971, DateTimeKind.Utc).AddTicks(4865), "$2a$11$TZkBK3aujGSfLIdxr42wbulxyLx6GYirWJeDBCtQJ4z7/kzaDTL2a" });
        }
    }
}
