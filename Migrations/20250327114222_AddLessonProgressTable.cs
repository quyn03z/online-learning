using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearning.Migrations
{
    /// <inheritdoc />
    public partial class AddLessonProgressTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LessonProgresses",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    LessonId = table.Column<long>(type: "bigint", nullable: false),
                    CompletedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonProgresses", x => new { x.UserId, x.LessonId });
                    table.ForeignKey(
                        name: "FK_LessonProgresses_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "LessonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LessonProgresses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AITrainingData",
                keyColumn: "DataId",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 42, 22, 43, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "AITrainingData",
                keyColumn: "DataId",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 42, 22, 43, DateTimeKind.Local).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 42, 22, 43, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 42, 22, 43, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 42, 22, 43, DateTimeKind.Local).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 42, 22, 43, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 42, 22, 43, DateTimeKind.Local).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 42, 22, 43, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 42, 22, 43, DateTimeKind.Local).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 42, 22, 43, DateTimeKind.Local).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 42, 22, 43, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 42, 22, 43, DateTimeKind.Local).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 42, 22, 43, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 42, 22, 43, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 42, 22, 43, DateTimeKind.Local).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 42, 22, 43, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 42, 22, 43, DateTimeKind.Local).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 27, 18, 42, 22, 43, DateTimeKind.Local).AddTicks(1705), new DateTime(2025, 3, 27, 18, 42, 22, 43, DateTimeKind.Local).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 27, 18, 42, 22, 43, DateTimeKind.Local).AddTicks(1794), new DateTime(2025, 3, 27, 18, 42, 22, 43, DateTimeKind.Local).AddTicks(1794) });

            migrationBuilder.CreateIndex(
                name: "IX_LessonProgresses_LessonId",
                table: "LessonProgresses",
                column: "LessonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LessonProgresses");

            migrationBuilder.UpdateData(
                table: "AITrainingData",
                keyColumn: "DataId",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 40, 47, 796, DateTimeKind.Local).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "AITrainingData",
                keyColumn: "DataId",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 40, 47, 796, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 40, 47, 796, DateTimeKind.Local).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 40, 47, 796, DateTimeKind.Local).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 40, 47, 796, DateTimeKind.Local).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 40, 47, 796, DateTimeKind.Local).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 40, 47, 796, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 40, 47, 796, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 40, 47, 796, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 40, 47, 796, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 40, 47, 796, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 40, 47, 796, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 11L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 40, 47, 796, DateTimeKind.Local).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 12L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 40, 47, 796, DateTimeKind.Local).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 13L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 40, 47, 796, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 14L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 40, 47, 796, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 15L,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 27, 18, 40, 47, 796, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 27, 18, 40, 47, 796, DateTimeKind.Local).AddTicks(6072), new DateTime(2025, 3, 27, 18, 40, 47, 796, DateTimeKind.Local).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 27, 18, 40, 47, 796, DateTimeKind.Local).AddTicks(6156), new DateTime(2025, 3, 27, 18, 40, 47, 796, DateTimeKind.Local).AddTicks(6157) });
        }
    }
}
