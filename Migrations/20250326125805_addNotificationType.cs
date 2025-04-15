using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearning.Migrations
{
    /// <inheritdoc />
    public partial class addNotificationType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NotificationType",
                table: "Notifications",
                type: "VARCHAR(20)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotificationType",
                table: "Notifications");

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
