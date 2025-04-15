using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearning.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NotificationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<long>(type: "bigint", nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.NotificationId);
                    table.ForeignKey(
                        name: "FK_Notifications_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 18, 14, 28, 33, 212, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 18, 14, 28, 33, 212, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 18, 14, 28, 33, 212, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 18, 14, 28, 33, 212, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 18, 14, 28, 33, 212, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 18, 14, 28, 33, 212, DateTimeKind.Local).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 18, 14, 28, 33, 212, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 18, 14, 28, 33, 212, DateTimeKind.Local).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 18, 14, 28, 33, 212, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 18, 14, 28, 33, 212, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 18, 14, 28, 33, 212, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 18, 14, 28, 33, 212, DateTimeKind.Local).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 18, 14, 28, 33, 212, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 18, 14, 28, 33, 212, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 18, 14, 28, 33, 212, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 18, 14, 28, 33, 212, DateTimeKind.Local).AddTicks(4094), new DateTime(2025, 3, 18, 14, 28, 33, 212, DateTimeKind.Local).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 18, 14, 28, 33, 212, DateTimeKind.Local).AddTicks(4208), new DateTime(2025, 3, 18, 14, 28, 33, 212, DateTimeKind.Local).AddTicks(4209) });

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_CourseId",
                table: "Notifications",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 0, 49, 54, 548, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 0, 49, 54, 548, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 0, 49, 54, 548, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 0, 49, 54, 548, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 0, 49, 54, 548, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 0, 49, 54, 548, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 0, 49, 54, 548, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 0, 49, 54, 548, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 0, 49, 54, 548, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 0, 49, 54, 548, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 0, 49, 54, 548, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 0, 49, 54, 548, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 0, 49, 54, 548, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 0, 49, 54, 548, DateTimeKind.Local).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 0, 49, 54, 548, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 5, 0, 49, 54, 548, DateTimeKind.Local).AddTicks(8702), new DateTime(2025, 3, 5, 0, 49, 54, 548, DateTimeKind.Local).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 5, 0, 49, 54, 548, DateTimeKind.Local).AddTicks(8806), new DateTime(2025, 3, 5, 0, 49, 54, 548, DateTimeKind.Local).AddTicks(8807) });
        }
    }
}
