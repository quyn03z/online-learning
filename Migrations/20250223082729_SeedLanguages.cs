using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineLearning.Migrations
{
    /// <inheritdoc />
    public partial class SeedLanguages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "CreatedAt", "DeletedAt", "LanguageName", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 2, 23, 15, 27, 28, 364, DateTimeKind.Local).AddTicks(1657), null, "English", 2, null },
                    { 2L, new DateTime(2025, 2, 23, 15, 27, 28, 364, DateTimeKind.Local).AddTicks(1661), null, "Spanish", 2, null },
                    { 3L, new DateTime(2025, 2, 23, 15, 27, 28, 364, DateTimeKind.Local).AddTicks(1663), null, "Mandarin Chinese", 2, null },
                    { 4L, new DateTime(2025, 2, 23, 15, 27, 28, 364, DateTimeKind.Local).AddTicks(1664), null, "Hindi", 2, null },
                    { 5L, new DateTime(2025, 2, 23, 15, 27, 28, 364, DateTimeKind.Local).AddTicks(1666), null, "Arabic", 2, null },
                    { 6L, new DateTime(2025, 2, 23, 15, 27, 28, 364, DateTimeKind.Local).AddTicks(1669), null, "Bengali", 2, null },
                    { 7L, new DateTime(2025, 2, 23, 15, 27, 28, 364, DateTimeKind.Local).AddTicks(1671), null, "Portuguese", 2, null },
                    { 8L, new DateTime(2025, 2, 23, 15, 27, 28, 364, DateTimeKind.Local).AddTicks(1673), null, "Russian", 2, null },
                    { 9L, new DateTime(2025, 2, 23, 15, 27, 28, 364, DateTimeKind.Local).AddTicks(1674), null, "Japanese", 2, null },
                    { 10L, new DateTime(2025, 2, 23, 15, 27, 28, 364, DateTimeKind.Local).AddTicks(1676), null, "Vietnamese", 2, null },
                    { 11L, new DateTime(2025, 2, 23, 15, 27, 28, 364, DateTimeKind.Local).AddTicks(1678), null, "Korean", 2, null },
                    { 12L, new DateTime(2025, 2, 23, 15, 27, 28, 364, DateTimeKind.Local).AddTicks(1679), null, "French", 2, null },
                    { 13L, new DateTime(2025, 2, 23, 15, 27, 28, 364, DateTimeKind.Local).AddTicks(1681), null, "German", 2, null },
                    { 14L, new DateTime(2025, 2, 23, 15, 27, 28, 364, DateTimeKind.Local).AddTicks(1682), null, "Italian", 2, null },
                    { 15L, new DateTime(2025, 2, 23, 15, 27, 28, 364, DateTimeKind.Local).AddTicks(1684), null, "Turkish", 2, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 27, 28, 364, DateTimeKind.Local).AddTicks(1307), new DateTime(2025, 2, 23, 15, 27, 28, 364, DateTimeKind.Local).AddTicks(1318) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 27, 28, 364, DateTimeKind.Local).AddTicks(1405), new DateTime(2025, 2, 23, 15, 27, 28, 364, DateTimeKind.Local).AddTicks(1406) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 15L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 20, 32, 54, 719, DateTimeKind.Local).AddTicks(3784), new DateTime(2025, 2, 22, 20, 32, 54, 719, DateTimeKind.Local).AddTicks(3794) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 20, 32, 54, 719, DateTimeKind.Local).AddTicks(3871), new DateTime(2025, 2, 22, 20, 32, 54, 719, DateTimeKind.Local).AddTicks(3872) });
        }
    }
}
