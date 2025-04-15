using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearning.Migrations
{
    /// <inheritdoc />
    public partial class addNotificationIsClear : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCleared",
                table: "Notifications",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AITrainingData",
                keyColumn: "DataId",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "AITrainingData",
                keyColumn: "DataId",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(6828), new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(6844) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7016), new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7018) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCleared",
                table: "Notifications");

            migrationBuilder.UpdateData(
                table: "AITrainingData",
                keyColumn: "DataId",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 19, 58, 2, 623, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "AITrainingData",
                keyColumn: "DataId",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 19, 58, 2, 623, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 19, 58, 2, 623, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 19, 58, 2, 623, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 19, 58, 2, 623, DateTimeKind.Local).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 19, 58, 2, 623, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 19, 58, 2, 623, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 19, 58, 2, 623, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 19, 58, 2, 623, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 19, 58, 2, 623, DateTimeKind.Local).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 19, 58, 2, 623, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 19, 58, 2, 623, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 19, 58, 2, 623, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 19, 58, 2, 623, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 19, 58, 2, 623, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 19, 58, 2, 623, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 26, 19, 58, 2, 623, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 26, 19, 58, 2, 623, DateTimeKind.Local).AddTicks(3982), new DateTime(2025, 3, 26, 19, 58, 2, 623, DateTimeKind.Local).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 26, 19, 58, 2, 623, DateTimeKind.Local).AddTicks(4087), new DateTime(2025, 3, 26, 19, 58, 2, 623, DateTimeKind.Local).AddTicks(4087) });
        }
    }
}
