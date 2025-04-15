using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearning.Migrations
{
    /// <inheritdoc />
    public partial class FixQuestionTypeConversion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Questions",
                type: "int",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.UpdateData(
                table: "AITrainingData",
                keyColumn: "DataId",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 17, 40, 206, DateTimeKind.Local).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "AITrainingData",
                keyColumn: "DataId",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 17, 40, 206, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 17, 40, 206, DateTimeKind.Local).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 17, 40, 206, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 17, 40, 206, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 17, 40, 206, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 17, 40, 206, DateTimeKind.Local).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 17, 40, 206, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 17, 40, 206, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 17, 40, 206, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 17, 40, 206, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 17, 40, 206, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 17, 40, 206, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 17, 40, 206, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 17, 40, 206, DateTimeKind.Local).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 17, 40, 206, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 17, 40, 206, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 26, 20, 17, 40, 206, DateTimeKind.Local).AddTicks(2936), new DateTime(2025, 3, 26, 20, 17, 40, 206, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 26, 20, 17, 40, 206, DateTimeKind.Local).AddTicks(3171), new DateTime(2025, 3, 26, 20, 17, 40, 206, DateTimeKind.Local).AddTicks(3172) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Questions",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 20);

            migrationBuilder.UpdateData(
                table: "AITrainingData",
                keyColumn: "DataId",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 19, 14, 13, 58, 357, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "AITrainingData",
                keyColumn: "DataId",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 19, 14, 13, 58, 357, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 19, 14, 13, 58, 357, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 19, 14, 13, 58, 357, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 19, 14, 13, 58, 357, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 19, 14, 13, 58, 357, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 19, 14, 13, 58, 357, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 19, 14, 13, 58, 357, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 19, 14, 13, 58, 357, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 19, 14, 13, 58, 357, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 19, 14, 13, 58, 357, DateTimeKind.Local).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 19, 14, 13, 58, 357, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 19, 14, 13, 58, 357, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 19, 14, 13, 58, 357, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 19, 14, 13, 58, 357, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 19, 14, 13, 58, 357, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 19, 14, 13, 58, 357, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 19, 14, 13, 58, 357, DateTimeKind.Local).AddTicks(7877), new DateTime(2025, 3, 19, 14, 13, 58, 357, DateTimeKind.Local).AddTicks(7888) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 19, 14, 13, 58, 357, DateTimeKind.Local).AddTicks(7973), new DateTime(2025, 3, 19, 14, 13, 58, 357, DateTimeKind.Local).AddTicks(7973) });
        }
    }
}
