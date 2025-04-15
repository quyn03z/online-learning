using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineLearning.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRoleData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 2, 3L },
                    { 3, 4L },
                    { 2, 5L },
                    { 1, 6L },
                    { 2, 7L },
                    { 2, 8L },
                    { 2, 9L },
                    { 3, 10L },
                    { 2, 11L },
                    { 3, 12L },
                    { 2, 13L },
                    { 3, 14L },
                    { 1, 15L },
                    { 3, 16L },
                    { 1, 17L },
                    { 1, 18L },
                    { 1, 19L },
                    { 2, 20L },
                    { 1, 21L },
                    { 3, 22L },
                    { 2, 23L },
                    { 3, 24L },
                    { 1, 25L },
                    { 1, 26L },
                    { 2, 27L },
                    { 3, 28L },
                    { 3, 29L },
                    { 2, 30L },
                    { 2, 31L },
                    { 3, 32L },
                    { 2, 33L },
                    { 3, 34L },
                    { 2, 35L },
                    { 1, 36L },
                    { 1, 37L },
                    { 2, 38L },
                    { 1, 39L },
                    { 1, 40L },
                    { 1, 41L },
                    { 3, 42L },
                    { 3, 43L },
                    { 2, 44L },
                    { 3, 45L },
                    { 3, 46L },
                    { 3, 47L },
                    { 3, 48L },
                    { 3, 49L },
                    { 2, 50L },
                    { 1, 51L },
                    { 1, 52L },
                    { 2, 53L },
                    { 2, 54L },
                    { 3, 55L },
                    { 2, 56L },
                    { 3, 57L },
                    { 1, 58L },
                    { 3, 59L },
                    { 2, 60L },
                    { 1, 61L },
                    { 3, 62L },
                    { 3, 63L },
                    { 2, 64L },
                    { 3, 65L },
                    { 2, 66L },
                    { 3, 67L },
                    { 1, 68L },
                    { 2, 69L },
                    { 2, 70L },
                    { 1, 71L },
                    { 1, 72L },
                    { 2, 73L },
                    { 2, 74L },
                    { 3, 75L },
                    { 2, 76L },
                    { 1, 77L },
                    { 2, 78L },
                    { 1, 79L },
                    { 2, 80L },
                    { 2, 81L },
                    { 2, 82L },
                    { 1, 83L },
                    { 3, 84L },
                    { 3, 85L },
                    { 1, 86L },
                    { 3, 87L },
                    { 2, 88L },
                    { 2, 89L },
                    { 1, 90L },
                    { 3, 91L },
                    { 2, 92L },
                    { 3, 93L },
                    { 3, 94L },
                    { 2, 95L },
                    { 3, 96L },
                    { 1, 97L },
                    { 1, 98L },
                    { 2, 99L },
                    { 3, 100L }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 28, 14, 2, 31, 989, DateTimeKind.Local).AddTicks(7802), new DateTime(2025, 3, 28, 14, 2, 31, 989, DateTimeKind.Local).AddTicks(7802) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 28, 14, 2, 31, 989, DateTimeKind.Local).AddTicks(7817), new DateTime(2025, 3, 28, 14, 2, 31, 989, DateTimeKind.Local).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "demetrius@goodwin.info", "Mr. Monique Kerluke", false, "$2a$11$hiEcFwthxlubVebU9u19ve1TNMtuDp8YQMHndopazpYeWATViOvxu", "9071954116", new DateTime(2025, 3, 28, 14, 2, 31, 989, DateTimeKind.Local).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "rosamond@barrowsvolkman.info", "Miss Grady Sherwood Hermann IV", "$2a$11$1LnD4UvJ2.ZxesmxGQZnKu.0af6ZeXvnQIKwCIWZx04WN8tN4qgPu", "8503042097", new DateTime(2025, 3, 28, 14, 2, 32, 124, DateTimeKind.Local).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "nikki@greenfelder.us", "Prof. Collin Connelly", "$2a$11$jIXXJHo533fODRq/jfB6yeDdrHJN/yrV2xkPmTPXWyHRk3VfxvbHG", "7861299749", new DateTime(2025, 3, 28, 14, 2, 32, 258, DateTimeKind.Local).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "melody@miller.uk", "Laurie Borer", false, "$2a$11$rl9hW7sQ3zMy1oPZVW2PO.aNj62tr9YU2OK0/b1kZyGD5CGzgMe6y", "8568014641", new DateTime(2025, 3, 28, 14, 2, 32, 391, DateTimeKind.Local).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "ariane@dickikuphal.us", "Milton Hirthe", "$2a$11$Qrlya2EgIjtSN3MYZnRa3.PNQdIJcslXh5uYS7HZAZSa8L24yRHvO", "7681143230", new DateTime(2025, 3, 28, 14, 2, 32, 525, DateTimeKind.Local).AddTicks(6191) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "alyson@mullerwillms.name", "Orrin Xzavier Cassin II", "$2a$11$MmF15BBTUDDcnrSQZB94hO4GqjmSnNIhdUWlmbmY/eQ3LM2KqPDRu", "7737505919", new DateTime(2025, 3, 28, 14, 2, 32, 659, DateTimeKind.Local).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "gage@durgan.biz", "Caden Spinka", "$2a$11$1pkrQLA0TM6eUHB2MuX2Mu4w7MI7rV60QMhEPVurYuLyQbHH8ZZau", "7540662926", new DateTime(2025, 3, 28, 14, 2, 32, 790, DateTimeKind.Local).AddTicks(8309) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "troy@adams.co.uk", "Abner Torphy", "$2a$11$rllowPOOcjbNcUcG4.68LOSuq2TUbJELR05sSvsC.3RHxOGs2ya3G", "7176715578", new DateTime(2025, 3, 28, 14, 2, 32, 922, DateTimeKind.Local).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "katelyn@mohrmoore.ca", "Darien Jessika Kassulke IV", "$2a$11$hr728FQGD5lMSsUc5vkBOej9nBmjalHRmHNxAQOjL1lfcyK4.x4A.", "9434684699", new DateTime(2025, 3, 28, 14, 2, 33, 53, DateTimeKind.Local).AddTicks(5656) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "kareem_simonis@ward.co.uk", "Lindsey Walker", false, "$2a$11$KOtw1Es4Pg3pinSLAzfYpeV5OMFzeDXvKOMryFRsr9dUSL2IwrGXm", "1703799839", new DateTime(2025, 3, 28, 14, 2, 33, 185, DateTimeKind.Local).AddTicks(4395) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "marcellus.kovacek@greenfelder.biz", "Iliana Smith", false, "$2a$11$yI7sUEttzk6uIF/uUwIPbetIc5ou8sB6M1f79ffqVExL0nNVI8wka", "7035861023", new DateTime(2025, 3, 28, 14, 2, 33, 316, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "imani@veum.info", "Lempi Runolfsson", "$2a$11$uB8Qwrn.7Jx29UsNxJmFUeybhFCRW4Pp.Oj3RunpcqAnthnNHXet2", "9399102529", new DateTime(2025, 3, 28, 14, 2, 33, 448, DateTimeKind.Local).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "mitchel@sawayn.biz", "Hailee Jakubowski", "$2a$11$xSHdRoLgg9iD.3ccQ.6QROkLJWTrpgdtdJAtaBkKsA87PNesBwvTS", "9582421308", new DateTime(2025, 3, 28, 14, 2, 33, 579, DateTimeKind.Local).AddTicks(9842) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "michelle@hyatt.ca", "Peggie Mraz", false, "$2a$11$qZ1VtbgCJ.YSUPPeSPfNhuB6pQ/5fmBbkLM/2jVzH5mr79jv99vMy", "7310817667", new DateTime(2025, 3, 28, 14, 2, 33, 711, DateTimeKind.Local).AddTicks(6208) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "lacy.mraz@grimes.us", "Rosemary Renner", "$2a$11$wyq6EOh1dHZ9IerJxXCIEeO44k.Z0ZbGGi/BeVK4pXSGkqiezd25y", "8772831462", new DateTime(2025, 3, 28, 14, 2, 33, 842, DateTimeKind.Local).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "favian_mcdermott@abshirestrosin.uk", "Araceli Leffler", "$2a$11$CqvwcdfEd.j1beHcfRpQ6urpphD/jLtzcghQfvJsUp98n6qbEdH1m", "8495994448", new DateTime(2025, 3, 28, 14, 2, 33, 973, DateTimeKind.Local).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "omari.hoeger@kinggusikowski.name", "Colton Hermann", "$2a$11$.nUkCm2nbMUYJH4oPIi9A.7F76HjpG/nkpAK6sxPK7l.AkznCS4me", "8306834013", new DateTime(2025, 3, 28, 14, 2, 34, 105, DateTimeKind.Local).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "antonia.kovacek@gleichnerveum.us", "Elliott Predovic", "$2a$11$Kn6ylk9eyeNHOU2XRm1zUe7L/UUaG//G0IymBHSZ0L/TAeeX9CEGS", "9282909368", new DateTime(2025, 3, 28, 14, 2, 34, 236, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "elenor@schmidt.ca", "Lola O'Hara", true, "$2a$11$WwTAA/Ut.iUyDMo3FFS.O.oH6MQkFi10O9kyCukO4WCLLW2JiNOte", "7607488108", new DateTime(2025, 3, 28, 14, 2, 34, 367, DateTimeKind.Local).AddTicks(6646) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "lyric@bosco.info", "Mr. Marlon Marques Nader I", true, "$2a$11$UDdqLqJrGp6CmdNHDEXHVOsLYzjEqqNZdQwaOCJF1wwKFZ8CnBUsi", "7024460277", new DateTime(2025, 3, 28, 14, 2, 34, 498, DateTimeKind.Local).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "jordan_schowalter@luettgenschmeler.uk", "Don McDermott", "$2a$11$O0cnNSztcgLyD35UGhJjmOOZpjOpbj9u/Zu84O4yP.j.BcS1BRype", "9519550223", new DateTime(2025, 3, 28, 14, 2, 34, 631, DateTimeKind.Local).AddTicks(7232) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "alycia@lynchschmidt.ca", "Clyde Keeling", "$2a$11$GFHd3yHMgV11HFobbDgPG.sNY0Yy68NyS0ujeN8A5YtxAeoNdH2bS", "1202039196", new DateTime(2025, 3, 28, 14, 2, 34, 763, DateTimeKind.Local).AddTicks(6436) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "genesis@mcclure.ca", "Mr. Celine Berenice Zemlak", false, "$2a$11$c293ShfyU3e29kDK3cjKQ.pDDhDNNEtH4Wsfw8OGAloKYCp8l2OA2", "9420927132", new DateTime(2025, 3, 28, 14, 2, 34, 894, DateTimeKind.Local).AddTicks(9561) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 26L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "taryn@wyman.info", "Dr. Donny Will Leuschke", true, "$2a$11$hjWg9aNwZ9/nb77lJTXdWOFIooAr0SyKQY9HBC/wNTjbItaM3dkWS", "1911403722", new DateTime(2025, 3, 28, 14, 2, 35, 25, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 27L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "jennyfer@reingerwilderman.name", "Mr. Wilson Jermain McLaughlin", false, "$2a$11$TC3Ov6LS3lzq1G9oeSjCO.yMOrvtjpGfEi.3C5nMXFxYanWGpP/7e", "8228243477", new DateTime(2025, 3, 28, 14, 2, 35, 157, DateTimeKind.Local).AddTicks(2424) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 28L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "louvenia.denesik@welch.ca", "Leann Bednar III", true, "$2a$11$M4XSMEF64udfoegUBU5a9O2ZhGihS9fW6H/u1GEhfNTnarb.y5Ena", "9822684693", new DateTime(2025, 3, 28, 14, 2, 35, 288, DateTimeKind.Local).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 29L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "jayne@skiles.uk", "Abraham McClure", true, "$2a$11$hLCJAVcfm/RlUch7yoprx.m3VnTnHBUE6E9indgDuMCm/9IMKu73y", "9222363306", new DateTime(2025, 3, 28, 14, 2, 35, 419, DateTimeKind.Local).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 30L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "perry@kutchglover.co.uk", "Drake Bogan", "$2a$11$W/O30xg8mZiPYqH7tYOZ5.mCwxiWS/D.i.W0h14OZV9MEuqf1a0si", "8815403842", new DateTime(2025, 3, 28, 14, 2, 35, 550, DateTimeKind.Local).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 31L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "leonie.zemlak@ruecker.biz", "Brenden Legros", true, "$2a$11$pbUyGgoNROA68RTre13ayeCT5l00eBqUulXQaCu47uPISqtWEFT2G", "8998633671", new DateTime(2025, 3, 28, 14, 2, 35, 681, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 32L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "deion@langworth.us", "Mrs. Emelia Erna Stroman DVM", "$2a$11$5M8TBv92t6W2c558Jn1eYOmIzeiMhPxitwAeIzdTXt57FhxK01W6i", "1820794630", new DateTime(2025, 3, 28, 14, 2, 35, 813, DateTimeKind.Local).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 33L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "justen_thiel@sporerkohler.co.uk", "Alda Upton", "$2a$11$0CIvr55SxVCM0d90L6MX4e0RaPvbMi697UyXQ65KQBNUD8UJ9Grte", "1577365681", new DateTime(2025, 3, 28, 14, 2, 35, 944, DateTimeKind.Local).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 34L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "emory_gerhold@bailey.info", "Vergie Maggio", false, "$2a$11$VA2zdnH6u9lOX0MQUIIJ4uD/szLymPRv0DE9PmjTesp9hS27JBYBe", "7455290906", new DateTime(2025, 3, 28, 14, 2, 36, 75, DateTimeKind.Local).AddTicks(5055) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 35L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "lee.kling@goodwintowne.uk", "Kavon Bruen", false, "$2a$11$9i7h3Z8emtB7ranoQORc.ecc9ybScnsNdB5LrZpWuyY5RcPxtja6a", "1829575347", new DateTime(2025, 3, 28, 14, 2, 36, 207, DateTimeKind.Local).AddTicks(6658) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 36L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "lisandro.smith@bruenrice.uk", "Mrs. Diana Torp DDS", "$2a$11$19xdLTi.i.xbJU/2sY8Tw.MB/g6lHFcuigYopEedoM7qENfaK8DY6", "9800287598", new DateTime(2025, 3, 28, 14, 2, 36, 339, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 37L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "alexandria@huelgutmann.us", "Kailee Johnson", false, "$2a$11$wtnHhrLhyFAurvCNPZQsmebrkgdthkwOfzz212OfYJG2wbrIEoODG", "9445311320", new DateTime(2025, 3, 28, 14, 2, 36, 470, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 38L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "brody_blanda@koch.ca", "Ms. Antonette Ebert II", "$2a$11$xwWG7hTA/LBHdFYbP31zkudUgBS/lR/IBVDyoOUJnLHyl8yZZLC2q", "8734699505", new DateTime(2025, 3, 28, 14, 2, 36, 601, DateTimeKind.Local).AddTicks(4866) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 39L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "gerard_quitzon@beer.ca", "Cornell Hilpert", true, "$2a$11$C.m045ds5Pzt/gZu4FJ3f.JaQVN6y41NzN8rTY22fJlftkQ.hmNYW", "7240823667", new DateTime(2025, 3, 28, 14, 2, 36, 733, DateTimeKind.Local).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 40L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "kristin.welch@brakus.ca", "Wilford Buck Wuckert I", false, "$2a$11$mw8E3e4D5f..Bw9m/ElYFe3wrof4cKIvpUYAbiTV5eXI6g9hUMPX2", "8506201538", new DateTime(2025, 3, 28, 14, 2, 36, 864, DateTimeKind.Local).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 41L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "nina_prohaska@streich.co.uk", "Christop Goldner", "$2a$11$D2O4ZzvfTBQsgevnGrR69.CytnS4miPUHfGALtL8MQz24CHmZvnS6", "8136734509", new DateTime(2025, 3, 28, 14, 2, 36, 996, DateTimeKind.Local).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 42L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "jaime@bergstrommarquardt.name", "Mrs. Stephanie Friedrich Wunsch Sr.", true, "$2a$11$baxjdqeCxgvCtDd/10fLBe2HdjAUQugEstXg.ldzhUXSfvyPodjFO", "1012383522", new DateTime(2025, 3, 28, 14, 2, 37, 127, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 43L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "torrance@hermann.biz", "Shanelle Heaney", true, "$2a$11$MCuymHw4fBTC6cOuWh3sX.DmDrfOI/mjLNYjWBHVxUSR71J1I4Nfy", "9522370713", new DateTime(2025, 3, 28, 14, 2, 37, 258, DateTimeKind.Local).AddTicks(4175) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 44L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "hobart.cummings@swift.com", "Jewell Barton", true, "$2a$11$aKB7l7OzHl.9whfkgrSrlOF6NOI3OTjYB2Xcqoc.pCiYdO7YWZ/am", "9741791177", new DateTime(2025, 3, 28, 14, 2, 37, 390, DateTimeKind.Local).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 45L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "ethyl.kohler@blick.name", "Ayana Linwood Abbott V", "$2a$11$g4nXnK03UJoHyzmzOkrkW.7sXTfVdFne6HZ2tqkHHWXnwUXHm9ZBm", "7514570838", new DateTime(2025, 3, 28, 14, 2, 37, 521, DateTimeKind.Local).AddTicks(6978) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 46L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "dorothy.king@brekke.co.uk", "Hildegard Vandervort", true, "$2a$11$Qe0TnJ61LCZhsvYyCfdZOe1O6nXA8d.cYdTrp/drJIVHlxodsR1YS", "7587774296", new DateTime(2025, 3, 28, 14, 2, 37, 653, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 47L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "drake.hickle@schillerwilliamson.biz", "Caleigh Talon Hettinger PhD", "$2a$11$epLUFlX1MqAu4iGA2O5J2O4xMG.EE7QOWskE76RfcdzD25XFCHkaK", "1484308244", new DateTime(2025, 3, 28, 14, 2, 37, 785, DateTimeKind.Local).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 48L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "rudy@block.uk", "Harrison Sauer II", true, "$2a$11$hlBn7BK9foXEZTpZFTjnQug3p7NgZ/coTzc.6BfMsoymDSq0YhIz.", "9491232966", new DateTime(2025, 3, 28, 14, 2, 37, 916, DateTimeKind.Local).AddTicks(5485) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 49L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "jayce@botsford.biz", "Eloy Smitham", "$2a$11$IsPTmjDnCCGlSB9Qd.rBYu/KqWkUObIs3.SgVz62nGp1utZtR7DKa", "7062818741", new DateTime(2025, 3, 28, 14, 2, 38, 47, DateTimeKind.Local).AddTicks(8456) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 50L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "lazaro@jenkins.ca", "Travis Cartwright", "$2a$11$gwu8cuzOwDgFor1HWM7Dduic5RNyZC5agPN511QtVxOL8Pfqgkp1e", "9334361706", new DateTime(2025, 3, 28, 14, 2, 38, 178, DateTimeKind.Local).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 51L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "sid_connelly@barrowslegros.biz", "Isaias Schamberger", "$2a$11$YMCKvrDJxACKM16QUxPzMeYZ6xYblntQMIaBuKVsCh.HelackHFDG", "9120632350", new DateTime(2025, 3, 28, 14, 2, 38, 309, DateTimeKind.Local).AddTicks(5553) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 52L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "presley@mcclure.us", "Karina Mann", true, "$2a$11$x4niJuN7X4oYl0h7Lp6zhuiRZBcRU5k.Rs/7HcIP9HpZNmQMXdeTe", "1508960513", new DateTime(2025, 3, 28, 14, 2, 38, 441, DateTimeKind.Local).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 53L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "conner.goodwin@ondricka.ca", "Ms. Devonte Irving Hauck", "$2a$11$aFbw5L92jR16Zz/ur9oA1O4QTyPCXh37QGzPIoKG7cCzFrSudDsTe", "9643928013", new DateTime(2025, 3, 28, 14, 2, 38, 572, DateTimeKind.Local).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 54L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "gerson@reichelhaley.co.uk", "Kurt Koss", true, "$2a$11$ZzzJuFR./EUgGfozo1gULuBx5qv8aqbTipMLqJJ2WD.ukkDPORaxu", "8810556419", new DateTime(2025, 3, 28, 14, 2, 38, 702, DateTimeKind.Local).AddTicks(6541) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 55L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "frederique@lehnerokon.uk", "Pauline Weimann", true, "$2a$11$eIjfsNVP683OrxCYErYsyuq0YSfLY9IRCrjZ2r5j7oFK6uaztUewu", "7528146605", new DateTime(2025, 3, 28, 14, 2, 38, 834, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 56L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "brook@weimann.uk", "Cynthia Conn", false, "$2a$11$3ilq4a618vqHfQ80fnN7w.JgnEnKNIrTbKV1G6cjmuXVBmWWV6fvq", "1321404689", new DateTime(2025, 3, 28, 14, 2, 38, 966, DateTimeKind.Local).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 57L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "jasper@emmerich.com", "Miss Lucy Barton", "$2a$11$fGu5w.muykG5ww0xA0wvquo1M0oVcuMQ5.OX5m.nOeWThdA3J9tDG", "1032389416", new DateTime(2025, 3, 28, 14, 2, 39, 97, DateTimeKind.Local).AddTicks(5508) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 58L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "eryn@schneidergreenholt.biz", "Broderick Gutkowski", false, "$2a$11$9z8qw3pmIlhdqQuJ2YP6b.Ucj7Y3aAJE0lvRKOPBPCdaZpyDh8CZi", "7424749529", new DateTime(2025, 3, 28, 14, 2, 39, 227, DateTimeKind.Local).AddTicks(666) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 59L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "garrick_prosacco@priceconroy.com", "Jovany Medhurst", "$2a$11$fbd4H/RwFbQ6BebHjbTRTuGSPb/kBhctL0cedbVtAS3nTHHY3loxC", "8501146953", new DateTime(2025, 3, 28, 14, 2, 39, 358, DateTimeKind.Local).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 60L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "matteo.anderson@runolfsson.ca", "Ms. Tate Robbie Wintheiser DDS", "$2a$11$pxeQ9QonebOA3W9jMCYkjuBNizkqFdg8/f1uAJaaQCdeZQnR5naUy", "7715821852", new DateTime(2025, 3, 28, 14, 2, 39, 490, DateTimeKind.Local).AddTicks(1332) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 61L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "emery.waters@stanton.us", "Dr. Aniyah Hamill I", false, "$2a$11$riQAO2NY4mX4ViQ4XB.W6O9eySjeV9UkHS36iImM/OLMVJdL1QKfK", "6905616435", new DateTime(2025, 3, 28, 14, 2, 39, 621, DateTimeKind.Local).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 62L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "greyson.nienow@ferry.biz", "Mckenzie Jerald Kemmer Sr.", "$2a$11$UF2fLhBnvSntWzKLnDq.Lu3CleSbvJDw/V6djr5UTdTAePdVjzsOC", "2046733549", new DateTime(2025, 3, 28, 14, 2, 39, 752, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 63L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "kennith_prohaska@buckridge.name", "Sigrid Shields DDS", true, "$2a$11$YdkpcAdimZJ9Hv.m7QflX.CEyD1GtGPsMz1yLRLus59vqzbOQooja", "9598633722", new DateTime(2025, 3, 28, 14, 2, 39, 884, DateTimeKind.Local).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 64L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "tania@hegmann.us", "Ms. Mckenzie Kelli Bednar I", true, "$2a$11$TFKsFW/txVaZSkVBafpKjOGOFCDHz7/UaA5UOLmYKaMziHQ3vudVq", "7129271652", new DateTime(2025, 3, 28, 14, 2, 40, 16, DateTimeKind.Local).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 65L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "zelda@yundt.uk", "Mrs. Barrett Jast DDS", false, "$2a$11$ax3p7iOy.WPrN2oXIKuzc.3U4doG6roOQHmskqsNWtoy.brlemOhK", "7296053622", new DateTime(2025, 3, 28, 14, 2, 40, 147, DateTimeKind.Local).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 66L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "george_boyer@welch.uk", "Ms. Lionel Swift I", true, "$2a$11$wSEDdO/6cx2Ttbtjy6Pn3u/5OmUr8YSrdWVnmq2cJVORusFfGWDXq", "7045482998", new DateTime(2025, 3, 28, 14, 2, 40, 278, DateTimeKind.Local).AddTicks(1053) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 67L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "darion_murray@west.us", "Eldora Estel Lehner Sr.", false, "$2a$11$yro3qYlmU6cJmvHK74SZse3nqIdSfma5P6s5x1D1KHqoO2Yx.vxRS", "9642565344", new DateTime(2025, 3, 28, 14, 2, 40, 409, DateTimeKind.Local).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 68L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "cheyanne.rolfson@mayert.com", "Ms. Sally Pfeffer", "$2a$11$/0jkcbCVXl1jtCfw/3pO4uiPulCjTUXphjFtkhRNI4alW46FM..Ji", "1152109581", new DateTime(2025, 3, 28, 14, 2, 40, 540, DateTimeKind.Local).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 69L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "orion@armstrongconroy.ca", "Mr. Arnoldo Hillard Grady", true, "$2a$11$k4cHnMXXksA9Z.S7uwfIU.bXvwKC6HjGSZh/2lG5ridyqehrFmZ3W", "9596447829", new DateTime(2025, 3, 28, 14, 2, 40, 671, DateTimeKind.Local).AddTicks(8248) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 70L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "gwen@kautzer.name", "Trevor Ritchie Sr.", "$2a$11$zRWN8E.tAy6n9pAw3qeUvOuyBoXarCjwdR6o73Dt1Wmf0kse38rUa", "9961642839", new DateTime(2025, 3, 28, 14, 2, 40, 805, DateTimeKind.Local).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 71L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "mariano@douglas.info", "Damon Stokes", true, "$2a$11$9k./8m7PqK9KffHOtPYpRe10t4udkIIbpEEfRVtWtH6BAiPRqwx4y", "8162915248", new DateTime(2025, 3, 28, 14, 2, 40, 936, DateTimeKind.Local).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 72L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "rosie.abbott@will.co.uk", "Mr. Eleazar Glover DVM", "$2a$11$9HBbWubesVqtOUoabvm6iO9Ussozl6/haOlqy46gho9Vbyo1zOCLu", "1426796504", new DateTime(2025, 3, 28, 14, 2, 41, 68, DateTimeKind.Local).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 73L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "clint_schoen@cassinhaley.us", "Prof. Elmira Hackett", "$2a$11$qErKGAD3izY90XapQw7pVezVxkN6Py8HC/vlPkJSFPlI9FYL8Fwrq", "6976897467", new DateTime(2025, 3, 28, 14, 2, 41, 200, DateTimeKind.Local).AddTicks(2677) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 74L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "lincoln@grahamernser.info", "Vito Kilback", "$2a$11$c25pXhs4sEc0Q.VPHf4Iie5GGJRePVstPw4/SOEV9GB/MEnM7GFva", "7681900574", new DateTime(2025, 3, 28, 14, 2, 41, 331, DateTimeKind.Local).AddTicks(8511) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 75L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "loyce@goyettekunze.uk", "Miss Rozella Alison Schmidt", "$2a$11$WDCFjfWhOYXnKbDbG20NyuN5ZbGe8djwdaQXGtEpUPJRl.B8/4cda", "7890386419", new DateTime(2025, 3, 28, 14, 2, 41, 463, DateTimeKind.Local).AddTicks(1311) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 76L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "trent_shields@hegmann.com", "Mrs. Quinton Waters", "$2a$11$CSjHXacEwBKkTOuFmhwAYelfRBi.xCkwG98pQsH38JNj3r04CbYj.", "8617745309", new DateTime(2025, 3, 28, 14, 2, 41, 595, DateTimeKind.Local).AddTicks(188) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 77L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "kariane_bechtelar@reingerbotsford.co.uk", "Ms. Clare Rice", true, "$2a$11$DoGtKkxkgbLVLwPVhTUZfeiUNWjgbEQUpBUTEplP747sUo1m43knG", "9236441068", new DateTime(2025, 3, 28, 14, 2, 41, 726, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 78L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "kaleigh_wilkinson@wolffhermiston.us", "Edison Lubowitz", "$2a$11$N5t/grp15gI5iz.32Ose3uMR5sriijsbs9CB3VMuL/OE4A39r/NJ6", "9557907849", new DateTime(2025, 3, 28, 14, 2, 41, 857, DateTimeKind.Local).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 79L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "nya@buckridge.info", "Mr. Leif Vita Toy", false, "$2a$11$a/.j3O/bOqn3tpS0qcrH7eOqHNlmtZsMpVLlqb60B7T3SD9gJOcLi", "9690775486", new DateTime(2025, 3, 28, 14, 2, 41, 990, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 80L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "isobel@durgan.biz", "Rosella Kris", true, "$2a$11$pdcDTsUQKEXxkcH.aSSUuO90.JL0MsxCjzPFnQeVJ0YMqaZmiUwc6", "7294821121", new DateTime(2025, 3, 28, 14, 2, 42, 124, DateTimeKind.Local).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 81L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "enrique.harvey@lynch.com", "Jaydon Wilkinson I", false, "$2a$11$klHL/.2lTrDq2zJvr4zQ9el3gJVDGSI6Ww82cPkBsWQ385gkZ5CKa", "8443567911", new DateTime(2025, 3, 28, 14, 2, 42, 257, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 82L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "jaydon_swift@waters.com", "Jasen Lynch", true, "$2a$11$DKNUbZZzZDQm7jnNGu.MwuEeybIwffMLXMZdnLX70wgU886zean2C", "9794943072", new DateTime(2025, 3, 28, 14, 2, 42, 388, DateTimeKind.Local).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 83L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "hilario.rippin@reichel.co.uk", "Mac Botsford", "$2a$11$1eV9Z54SwewSaS/jwxVmauqLC6sSoNbyWk2kGOovfLXiEbuKsEOEe", "9108906188", new DateTime(2025, 3, 28, 14, 2, 42, 519, DateTimeKind.Local).AddTicks(9534) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 84L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "green@toyleannon.uk", "Hilda Kyla Schultz MD", true, "$2a$11$BzG05LDMB4E4sixqeRZM7eRc.ibtn/9XC1VL8W3RmtUCcHS1IwsKa", "1236393674", new DateTime(2025, 3, 28, 14, 2, 42, 651, DateTimeKind.Local).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 85L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "lexie_olson@cummeratahammes.com", "Hazel Toy IV", "$2a$11$Oedqddn7vqPBEbxsaNX0ruvsq8HpnlgTBgJJOrpw/iG5h4BzraGF2", "1337099005", new DateTime(2025, 3, 28, 14, 2, 42, 782, DateTimeKind.Local).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 86L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "matteo@mcglynn.co.uk", "Rachelle Schuster", "$2a$11$Ki1dON0xq8LWwC9odYXs7OwjMJHviTbrxg6RdZSfg/WnOlyrA425i", "9286516036", new DateTime(2025, 3, 28, 14, 2, 42, 913, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 87L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "gerda_hilpert@hoppe.com", "Keagan Zemlak", false, "$2a$11$/ZQqB70PS/fHSpwfaR0fE.R9MEzT2IbrVZy3saC43gsVkRGi3upDi", "7234813624", new DateTime(2025, 3, 28, 14, 2, 43, 45, DateTimeKind.Local).AddTicks(7367) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 88L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "oda_maggio@wolf.co.uk", "Abbey Hilll", true, "$2a$11$J7oJNOgLBZaU9adob8V3K.wCw/hGlCBxYRygyt6U5IE.Llnen3maW", "1812449929", new DateTime(2025, 3, 28, 14, 2, 43, 177, DateTimeKind.Local).AddTicks(432) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 89L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "kolby_cummings@maggio.us", "Miss Cassandra Otho Schmitt", "$2a$11$Nd9jvE7mf.7amPbSmxVonOq22S88Oo8KOWUjOrOyeE42c1EfNnmKu", "1908122105", new DateTime(2025, 3, 28, 14, 2, 43, 308, DateTimeKind.Local).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 90L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "chauncey_hayes@kilback.com", "Derek Pfannerstill", false, "$2a$11$ERGvmAPPVy90kWUYuzqNC.qywaFQtyLGHCcGAWcXqCkbdO1anvbPG", "7819721075", new DateTime(2025, 3, 28, 14, 2, 43, 439, DateTimeKind.Local).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 91L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "joelle@herman.com", "Lew Pollich", "$2a$11$T0NQb5zqK9lK3Hmc2hGKn.do5Vgrn6Vg2sWYk1.RhtV70Pxps7ylS", "9666136158", new DateTime(2025, 3, 28, 14, 2, 43, 570, DateTimeKind.Local).AddTicks(4032) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 92L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "cole.murray@abshirepfannerstill.com", "Ms. Soledad Marco Larkin", false, "$2a$11$E4u5Ug7MBnoNxX5M3/upF..w3qazO.v/OrIMo5Ncgt8kZdY8rjIw6", "7898997998", new DateTime(2025, 3, 28, 14, 2, 43, 701, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 93L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "melyssa.carroll@oreilly.us", "Mr. Antonette Maximillia O'Keefe PhD", "$2a$11$ZCVOwIug1pZJKwaImGggTeAUJZX3tN4qs9Yx0o/FMlE06L3UBiCla", "7564908755", new DateTime(2025, 3, 28, 14, 2, 43, 839, DateTimeKind.Local).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 94L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "lysanne@bradtke.com", "Justus Conor Reichel DDS", true, "$2a$11$chdj4S.9ac.e.5fZh1FpauIf37QGK8c4c0y2.8Yx5BXRjbshEkt1K", "7169395563", new DateTime(2025, 3, 28, 14, 2, 43, 970, DateTimeKind.Local).AddTicks(6344) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 95L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "bobby.kovacek@jaskolski.ca", "Anibal Cole", "$2a$11$QUg46sq15lajxsIJkFHxje3foVMO73mG8wTp.bSv4Am7xid1.KoP6", "9175150485", new DateTime(2025, 3, 28, 14, 2, 44, 102, DateTimeKind.Local).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 96L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "vicente@stammhartmann.biz", "Elton Kutch", "$2a$11$uhYrRbk.Q3vYGG4Jn8l8uuvOuGJWHAlu8LCAC6V4p2txDebpaB536", "7027663329", new DateTime(2025, 3, 28, 14, 2, 44, 235, DateTimeKind.Local).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 97L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "vivienne@oconner.biz", "Giovani Gutmann DDS", "$2a$11$sWxiSjzFrU.bW.JrA08CZOBZv2SRbgvrNZdTMzVT5.k5315CdBH4i", "7655571778", new DateTime(2025, 3, 28, 14, 2, 44, 367, DateTimeKind.Local).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 98L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "myra@rosenbaumschuppe.com", "Kamron Beatty", true, "$2a$11$L7PHCtRzwV/WEgHn/V7Su.monhT2wI/rY5J9biQJGinFNuCrB/OQ6", "8499583199", new DateTime(2025, 3, 28, 14, 2, 44, 499, DateTimeKind.Local).AddTicks(229) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 99L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "ezekiel_berge@simonis.name", "Ms. Amiya Rosalia Ziemann", "$2a$11$o2fIZeBaYg17tO6eDrMOXu.540YABdira74VB9pifTnQ.oVWWB7Fi", "9631095156", new DateTime(2025, 3, 28, 14, 2, 44, 636, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 100L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "leilani_okuneva@franecki.us", "Jaylin Beer", false, "$2a$11$PI10QzReNepbz2Dich6ID.2OHnqLm0KbFdIk8vfZ/RY2Q3RiFTtXO", "1211293290", new DateTime(2025, 3, 28, 14, 2, 44, 767, DateTimeKind.Local).AddTicks(6153) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 3L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 4L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 5L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 6L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 7L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 8L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 9L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 10L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 11L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 12L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 13L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 14L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 15L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 16L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 17L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 18L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 19L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 20L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 21L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 22L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 23L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 24L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 25L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 26L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 27L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 28L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 29L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 30L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 31L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 32L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 33L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 34L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 35L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 36L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 37L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 38L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 39L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 40L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 41L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 42L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 43L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 44L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 45L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 46L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 47L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 48L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 49L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 50L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 51L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 52L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 53L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 54L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 55L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 56L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 57L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 58L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 59L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 60L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 61L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 62L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 63L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 64L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 65L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 66L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 67L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 68L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 69L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 70L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 71L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 72L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 73L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 74L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 75L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 76L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 77L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 78L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 79L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 80L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 81L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 82L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 83L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 84L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 85L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 86L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 87L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 88L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 89L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 90L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 91L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 92L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 93L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 94L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 95L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 96L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 97L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 98L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 99L });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 100L });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 28, 13, 52, 55, 827, DateTimeKind.Local).AddTicks(5010), new DateTime(2025, 3, 28, 13, 52, 55, 827, DateTimeKind.Local).AddTicks(5011) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 28, 13, 52, 55, 827, DateTimeKind.Local).AddTicks(5026), new DateTime(2025, 3, 28, 13, 52, 55, 827, DateTimeKind.Local).AddTicks(5026) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "jazmyne.kemmer@johnsonrunolfsson.us", "Lesly Langworth", true, "$2a$11$ZdM4GuLrTxG2aUW401/V7uTXyjALmTB6tTuJPJY9T3rKXrXped/Li", "7002940660", new DateTime(2025, 3, 28, 13, 52, 55, 827, DateTimeKind.Local).AddTicks(5034) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "marcella@murrayjenkins.uk", "Christelle Oberbrunner", "$2a$11$M4f/CflX.sQyBOHeRu6y4etI5tvx.TLW5CC2CdjQwmRX2oGx1Gq6y", "8648476843", new DateTime(2025, 3, 28, 13, 52, 55, 962, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "vernie.pollich@lynchroberts.us", "Prof. Katelyn Lucile Abbott V", "$2a$11$G4EfnwIIMA0unUaa48Dktu5v6KaY8o5RrYJ.qSLCwrZetc6PqT0/K", "7595119395", new DateTime(2025, 3, 28, 13, 52, 56, 97, DateTimeKind.Local).AddTicks(477) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "pedro_lowe@johns.biz", "Carmine Bernier", true, "$2a$11$YUuH1QR4p7rPvkwrfADKlORCukb2bjciK7ybdSTx6dzuqxCvz10D.", "9737207227", new DateTime(2025, 3, 28, 13, 52, 56, 229, DateTimeKind.Local).AddTicks(7528) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "liana.kirlin@dietrich.name", "Mr. Theresa Quigley", "$2a$11$gdfyojYSOWLmzUz6sHhYKOui35CyCTlS3zQNOlCaoCaVMTJRVoJb6", "7787036156", new DateTime(2025, 3, 28, 13, 52, 56, 361, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "lea@oconnell.info", "Aric Auer", "$2a$11$TpM17epq67CBsGwGV33EB.1Y2PI/Cy4zCPSZ3rNEtZ1aB4Trebe0G", "9991708034", new DateTime(2025, 3, 28, 13, 52, 56, 493, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "dustin_schiller@friesen.biz", "Jacey Bernier", "$2a$11$T621OjoFXwdNij6.o0O9T.ikB.Z/EEhWDJBz64rCUs92qteSRVVh.", "1040292516", new DateTime(2025, 3, 28, 13, 52, 56, 625, DateTimeKind.Local).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "korey@ruecker.info", "Liliane Schultz", "$2a$11$zbfPW8zgesHAMscnV/ER1uBZ7GJD/2j7Lzw12849HN5z3BN5fh5Ti", "8103331129", new DateTime(2025, 3, 28, 13, 52, 56, 757, DateTimeKind.Local).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "bette@altenwerthwhite.us", "Mrs. Drew Farrell MD", "$2a$11$Sw2x6oIyxIQbKDid9STY5uRbzDQqX.BVMKsoFZV5f28AuAYss9qAC", "8562818266", new DateTime(2025, 3, 28, 13, 52, 56, 888, DateTimeKind.Local).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "louisa.reichel@lakin.co.uk", "Piper Kulas", true, "$2a$11$bIDx2O8ED3nXx.JQGX1WZOVEsKcigOYd39KrrX5uromw5iRvScB1q", "9936749016", new DateTime(2025, 3, 28, 13, 52, 57, 19, DateTimeKind.Local).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "tessie_huel@lynch.name", "Mrs. Gerda Americo Mosciski V", true, "$2a$11$bHyOdYrDYDVi/J0SnBgzSOER8sTWtD3/VoDjwhL7Y76pCB7VPrR56", "9504766393", new DateTime(2025, 3, 28, 13, 52, 57, 151, DateTimeKind.Local).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "reva_vonrueden@runte.ca", "Grace Alec Hickle I", "$2a$11$xBpD4fRwrVTAwONT/NQUMe4Vv3TLC67w2ULeCLoxKOYSE7/JMOk9W", "1719564465", new DateTime(2025, 3, 28, 13, 52, 57, 283, DateTimeKind.Local).AddTicks(4194) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "vivienne@bayer.co.uk", "Winona Harvey", "$2a$11$ldJ2njg.GBIT4std38PJgujV2XslH4Nu5Dt8PEBXgAKuBCuVL9XN2", "8514134675", new DateTime(2025, 3, 28, 13, 52, 57, 414, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "nicholaus@langworthreynolds.uk", "Mrs. Katelin Cremin", true, "$2a$11$VI3weZa.Og4u00Y6iaiFmeGtYyD0HmyoWIs4qp/BUuj0bv6vydMge", "9353582560", new DateTime(2025, 3, 28, 13, 52, 57, 546, DateTimeKind.Local).AddTicks(1965) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "isom_simonis@rice.biz", "Dakota Heathcote", "$2a$11$mZgi82yb1Fa.PZvzKbJmzujQe/wKeD2en/.mXPeK.VCAaG1uTMesS", "7653528053", new DateTime(2025, 3, 28, 13, 52, 57, 677, DateTimeKind.Local).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "korbin@wyman.uk", "Thaddeus Schumm", "$2a$11$V7evTPSyppF4JHtmpclnFOhQhUJT/fnKTMUKpQ.wwevbIGqDExtHO", "6902583477", new DateTime(2025, 3, 28, 13, 52, 57, 809, DateTimeKind.Local).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "gerda.considine@kemmershields.name", "Juana Lindgren", "$2a$11$/ZNqf1Zv4xMLcx6iMB1snOsqeSRHWvnm2QYe9krs6WJAba9L4mpp.", "9134866426", new DateTime(2025, 3, 28, 13, 52, 57, 940, DateTimeKind.Local).AddTicks(3736) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "juanita.roob@kerluke.uk", "Dayana Hagenes", "$2a$11$DN5HliulbolpeYxHdGfIBeiBIrmeHVcMc7430DsOU9oH0KpQIYEhi", "1759961643", new DateTime(2025, 3, 28, 13, 52, 58, 71, DateTimeKind.Local).AddTicks(4463) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "annamae.grimes@wymanschneider.com", "Audie Gusikowski", false, "$2a$11$wGoUYr99nTSQpon08W0fYehw4mZtik1IP.68Zz5kRjFfVhjzhNyhm", "8678212914", new DateTime(2025, 3, 28, 13, 52, 58, 203, DateTimeKind.Local).AddTicks(2659) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "reece_boyer@smithamkris.ca", "Jennings Douglas", false, "$2a$11$oJqW1QiLYDMZvwcKGVRnE.GvL.24Uex9JbBAFYVhHAasqKc4dYciO", "8453281758", new DateTime(2025, 3, 28, 13, 52, 58, 335, DateTimeKind.Local).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "colleen@gerlach.info", "Daniela Delfina Wyman Sr.", "$2a$11$n4UibTqmNYLtQJBLbs3Er.KHJ3Hzq6zwoQwp0LngB4zLq2WTgoX46", "8602774070", new DateTime(2025, 3, 28, 13, 52, 58, 466, DateTimeKind.Local).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "mona@mclaughlin.us", "Marcelo Mertz", "$2a$11$/5lCpVDnxbK/cl3daCvaN.fqExIs5fjWzr9L6KNsI/s.eGzg.Yun6", "8829272930", new DateTime(2025, 3, 28, 13, 52, 58, 598, DateTimeKind.Local).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "marcia@pagac.uk", "Mr. Maud Lew Herman IV", true, "$2a$11$6dmD0zPpygTpbd0zsJwJ8upWS.a.CYvXuWa77CtQ3qTueqwALCLrm", "9715987755", new DateTime(2025, 3, 28, 13, 52, 58, 730, DateTimeKind.Local).AddTicks(5367) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 26L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "jed.mertz@larkinschroeder.name", "Shirley Jaskolski", false, "$2a$11$DBPNYK.tb8rNEpK.Mbg1VuhAAo1PZhG8Fc6mOUXlPytd5VzojqeuK", "8987662042", new DateTime(2025, 3, 28, 13, 52, 58, 861, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 27L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "erika@crist.uk", "Marlee Swaniawski", true, "$2a$11$t5vuhbmmmyD8afU2Jek8MuUHl7hxEU.D4OwImp8tod6RLI9qzldwu", "7570696853", new DateTime(2025, 3, 28, 13, 52, 58, 995, DateTimeKind.Local).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 28L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "ellie@bechtelar.biz", "Miss Sheridan Opal Effertz Jr.", false, "$2a$11$XCMDs0vfgh8/oXFY0aIZwuPMAtal7QetpQZwG/2D3O8iHZnz5UoNm", "2094280177", new DateTime(2025, 3, 28, 13, 52, 59, 127, DateTimeKind.Local).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 29L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "stephanie@trantowwalter.com", "Isom Blick", false, "$2a$11$.Tnn000EGr.tf4U73u7FvuDima7do8V6MkYsLErgUWEPYrhhE13fi", "9334438022", new DateTime(2025, 3, 28, 13, 52, 59, 259, DateTimeKind.Local).AddTicks(801) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 30L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "jolie_stracke@franecki.us", "Maryse Romaguera", "$2a$11$GxkVJa4o7XBVKFJqRmtrYufuRv.SP9DVocXB1yM42u0Lcu7/me9UO", "1664119593", new DateTime(2025, 3, 28, 13, 52, 59, 390, DateTimeKind.Local).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 31L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "travon_christiansen@kutchhoeger.us", "Jeremie Barton", false, "$2a$11$ctx80AW1f2Wy8bRuj9wn9udI35EXfXeDbNEAFBFyP.w3AGH2xv316", "8893615701", new DateTime(2025, 3, 28, 13, 52, 59, 522, DateTimeKind.Local).AddTicks(5057) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 32L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "nellie.goldner@lynch.uk", "Vance Hermiston", "$2a$11$ZibCf1OD9zeInlrB6TRmlesHcN5RPuSSIMJDq2U6qsfIajYwEvg3y", "8149002105", new DateTime(2025, 3, 28, 13, 52, 59, 653, DateTimeKind.Local).AddTicks(8294) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 33L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "myrtie@paucek.info", "Katarina Clark Weissnat IV", "$2a$11$/3AmMVAD4ORD9kCHAooOiOsgxzTdNeqayGQi5IGEDO0KlEYQnJsma", "7495887360", new DateTime(2025, 3, 28, 13, 52, 59, 785, DateTimeKind.Local).AddTicks(7506) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 34L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "layla.maggio@kutch.name", "Francesca Abshire", true, "$2a$11$90je6zqQ7pw6B5KehH.5IuPBmRv5dEERewbACJaGCu1rF/FtnuWiG", "8448374039", new DateTime(2025, 3, 28, 13, 52, 59, 917, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 35L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "edison@bechtelar.biz", "Melany VonRueden", true, "$2a$11$AAycQj6HDH0P3UsiQaHmMuqYOjw8l5VpamIU/i7AKsQUGyYU/nK76", "7151923038", new DateTime(2025, 3, 28, 13, 53, 0, 49, DateTimeKind.Local).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 36L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "madilyn@carter.com", "Ms. Dolores Kole Batz Sr.", "$2a$11$zROvXnfwPZMp78OYTspAvOY/zD9CQCXx.CGpcbhdUyJayb7UZLm.O", "6958306559", new DateTime(2025, 3, 28, 13, 53, 0, 180, DateTimeKind.Local).AddTicks(9189) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 37L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "elvie@townemurazik.us", "Mr. Nathan Dejon Parker II", true, "$2a$11$YU2JxWyWJEauBtfkmzpcfeBjGkVptI7exva3LA3qu2xMeNb.NkY2u", "8307557501", new DateTime(2025, 3, 28, 13, 53, 0, 312, DateTimeKind.Local).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 38L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "percy@keebler.co.uk", "Jan Gorczany DDS", "$2a$11$DDejIRlFTBUj/5f56c/bMOqNVg83CIgFnzecmk5NeTtE1wQjwiMLS", "9206557399", new DateTime(2025, 3, 28, 13, 53, 0, 444, DateTimeKind.Local).AddTicks(3791) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 39L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "johathan.kautzer@tromp.ca", "Webster Mayert DDS", false, "$2a$11$6zHNKumbFbWcjj9WLSPdYu2Ys8zPGn7zppCe2HIDiC.fNoFfCf8z.", "7878291378", new DateTime(2025, 3, 28, 13, 53, 0, 576, DateTimeKind.Local).AddTicks(3712) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 40L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "lizzie_ziemann@jacobson.com", "Caitlyn Amiya Nicolas Sr.", true, "$2a$11$17GIdY15idjj/deRNYc2fuXN1m2UaQq2phqD3WwZ8tRhjFSgsZPlC", "8094415600", new DateTime(2025, 3, 28, 13, 53, 0, 708, DateTimeKind.Local).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 41L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "prince_treutel@fritsch.name", "Miss Myrtis Lexi Pacocha", "$2a$11$6WlOFk/pq1.Tw4YI.YvdUec0rEE9jRW0/tUDwbmxXbokk.kLx/n46", "1240063278", new DateTime(2025, 3, 28, 13, 53, 0, 841, DateTimeKind.Local).AddTicks(8543) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 42L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "norval@mraz.uk", "Moshe Pacocha", false, "$2a$11$enm34kml0SkNC8H1lOGsueUTWlA/msYrQnsLMJEkwvk.B/LKR3IIi", "7550758535", new DateTime(2025, 3, 28, 13, 53, 0, 976, DateTimeKind.Local).AddTicks(2645) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 43L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "candelario.stanton@fahey.info", "Gabriel Fritsch", false, "$2a$11$v4l13repMwcaoTLBnud.Duth6qnPSGNMllyCE221dzHiOjl6KK0tu", "8177887386", new DateTime(2025, 3, 28, 13, 53, 1, 108, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 44L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "ron_reynolds@johnson.name", "Isabel Kozey", false, "$2a$11$frj1a7v9ZCLurx.47g68UeUWrgl3A5RO.iTdF8uJpsTkTV/gqCCaO", "8409078155", new DateTime(2025, 3, 28, 13, 53, 1, 240, DateTimeKind.Local).AddTicks(8434) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 45L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "ambrose.kihn@bartoletti.us", "Tod Cremin", "$2a$11$NwjUW8j0y5AScvxkTLWnG./pifVNTypkO1Ef5cCGm7ceRbk45arPC", "1284155859", new DateTime(2025, 3, 28, 13, 53, 1, 372, DateTimeKind.Local).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 46L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "leanne@donnelly.biz", "Prof. Carson Ernser", false, "$2a$11$9OwxgkSqMfKupjgwsYT8yeIJ2tqJ/I9ClDwM1pg9wTlVMfz2o4Pya", "1930003004", new DateTime(2025, 3, 28, 13, 53, 1, 504, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 47L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "sierra.boyer@haley.info", "Edwina Langosh", "$2a$11$hBsNwloQ.ubI5Vrr9Ac6/OPIDrzcshTaY4nxoVLllLkE8ROcsCOKG", "1735009422", new DateTime(2025, 3, 28, 13, 53, 1, 635, DateTimeKind.Local).AddTicks(6998) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 48L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "jermain@volkman.us", "Yolanda Charlotte Luettgen II", false, "$2a$11$qqzdclAy6BTj5MbYEY4Dd.bbdPJxOxA2S7LBWCOPxg/RPFt46ndsS", "7958386307", new DateTime(2025, 3, 28, 13, 53, 1, 767, DateTimeKind.Local).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 49L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "addison.pacocha@ohara.uk", "Lilla Weber", "$2a$11$KduA.YZ.U.VWDqnzLy8K3uDUOLCDYixXyYlZxetVtuC94.5U1bO3y", "1849792883", new DateTime(2025, 3, 28, 13, 53, 1, 899, DateTimeKind.Local).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 50L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "elva@leuschkehudson.uk", "Demarco Lubowitz", "$2a$11$6iLCMynTd7NTxIQyTsgWBeAi6H0FpKWXiGm8KFwtMme1KvLImSunC", "7984056461", new DateTime(2025, 3, 28, 13, 53, 2, 30, DateTimeKind.Local).AddTicks(9195) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 51L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "oral.jerde@kuhlman.us", "Mr. Vivianne Branson Carter II", "$2a$11$msjbWKQw3qz93poZ1ydm1.2o590h1jzRyiiG4SdP5CGUt2t2d0OQq", "1934711330", new DateTime(2025, 3, 28, 13, 53, 2, 162, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 52L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "orland@johnsonshields.co.uk", "Everardo Gerhold", false, "$2a$11$vXQsKLCIUrxa1INT/cOwoea7ndO8RJsrtg6EzTdtVZeSo7WwZ1pW.", "1824337243", new DateTime(2025, 3, 28, 13, 53, 2, 294, DateTimeKind.Local).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 53L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "mckayla@koelpin.com", "Ernesto Mante", "$2a$11$pk2UdS/YP9lGrN9rQagU8.jTOiZrxmDhw7cUg.Eofu4OWZ5QfAVBC", "7833168662", new DateTime(2025, 3, 28, 13, 53, 2, 426, DateTimeKind.Local).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 54L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "alba@oconnerjones.us", "Estevan Rosenbaum", false, "$2a$11$mzqEbgvCWqpENtudi6WmEOkDP39rDP.YdRM9uyKGlLGA7/dbyzUFS", "6862252024", new DateTime(2025, 3, 28, 13, 53, 2, 558, DateTimeKind.Local).AddTicks(115) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 55L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "rosetta@hahn.info", "Carol Rau", false, "$2a$11$TG/E8QkKw0zXgj4VK5oLfOa2Bb65cyL/oCUOzboG1o6zQOB6.HiC2", "7569635212", new DateTime(2025, 3, 28, 13, 53, 2, 689, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 56L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "dexter.corwin@corwin.com", "Torrey Kirk Schuster Jr.", true, "$2a$11$bYW6FZFwZKhwZsxcft0N2.yFdAy7o2nTWNdAt2UOA/iM7BtUkfHEy", "6908831925", new DateTime(2025, 3, 28, 13, 53, 2, 821, DateTimeKind.Local).AddTicks(3043) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 57L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "remington_champlin@sauer.uk", "Sophia Vandervort", "$2a$11$XSBFWghUMs28P8gMEXSnKu5xbfXhHTcV/akG0xYikkga/bhjg/5sW", "8081886145", new DateTime(2025, 3, 28, 13, 53, 2, 952, DateTimeKind.Local).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 58L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "erika@jewess.biz", "Lina Conroy", true, "$2a$11$cGMMB0X4K0/Xa6dasrhf6./98y3avCZyn4b6C/XmBwYPfJ0xRvgaa", "7508510318", new DateTime(2025, 3, 28, 13, 53, 3, 84, DateTimeKind.Local).AddTicks(6361) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 59L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "alicia.lesch@walshhaley.uk", "Addison Jayson Altenwerth DDS", "$2a$11$2g7TEnUG5CJw9DmDZYkqIuA7fVKzLa5mwGO6lkfEFCNqp5e08YRJu", "7317108154", new DateTime(2025, 3, 28, 13, 53, 3, 216, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 60L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "gabe_schneider@batz.uk", "Augustus Mann PhD", "$2a$11$egyz7kEF6SnAjM.AI1r3g.tQLLAzKhwMFrcs5zrJQjoH0JiyGQE2m", "9050901271", new DateTime(2025, 3, 28, 13, 53, 3, 348, DateTimeKind.Local).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 61L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "leatha@bauch.biz", "Arianna Wolf", true, "$2a$11$G.Sik7BwJ1lBIzcuK27WNuVG6gzJqYnAx5B7yfPpl7yNUgXEvH9LW", "7394180636", new DateTime(2025, 3, 28, 13, 53, 3, 480, DateTimeKind.Local).AddTicks(419) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 62L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "nikko@stammdaniel.biz", "Elwin Bins", "$2a$11$o0V3McvwJaIviekEHn0BkuoLADKNrjP6aDCnm3xDyRkKDqKNc0FPu", "9797420138", new DateTime(2025, 3, 28, 13, 53, 3, 612, DateTimeKind.Local).AddTicks(1059) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 63L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "bret@hellerortiz.info", "Everardo Blanda", false, "$2a$11$2cmZTbP.JOZ8ed5BoGXhVOberkJKyy.0UysjsGkLxEkcAdP90qVsa", "9218174787", new DateTime(2025, 3, 28, 13, 53, 3, 743, DateTimeKind.Local).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 64L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "rozella.volkman@andersonmoore.ca", "Nels Prosacco", false, "$2a$11$9CpsUxCtU7/cKAhwX/qKCOndZekQ5QUsLdQNKPjl4LI1WV3t65c8G", "7800838183", new DateTime(2025, 3, 28, 13, 53, 3, 875, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 65L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "urban_wisozk@volkmanfadel.com", "Dax Conn", true, "$2a$11$e//5TTw6ORrVH/05xYrm1OTVFy4ndZHl60aY/hq78VEHBzZYc5NeS", "6857735197", new DateTime(2025, 3, 28, 13, 53, 4, 7, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 66L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "joe@satterfieldschuster.com", "Lorna Robel", false, "$2a$11$ZEez7CPn1WCp2egS3z2J1uAj.X1Pr613/oWMkISLo/cyEphlsMo8m", "8606050639", new DateTime(2025, 3, 28, 13, 53, 4, 139, DateTimeKind.Local).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 67L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "gia_dare@okeefedietrich.com", "Gabe Macejkovic", true, "$2a$11$n2vIDKtS2sqVyHIekWyd2.j7opz70sw3tFaudfckVQ5xauNbhk/b2", "7236807515", new DateTime(2025, 3, 28, 13, 53, 4, 271, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 68L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "arden@hesselpfeffer.us", "Laurel Lehner", "$2a$11$pcd2GuhF6JNr7a2zUoHtT.Id.lAa6DLRgCgpykXruvcBHQ5pzTi3e", "8669407335", new DateTime(2025, 3, 28, 13, 53, 4, 402, DateTimeKind.Local).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 69L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "tyrel.gibson@cruickshankmitchell.biz", "Dorothea Lubowitz DDS", false, "$2a$11$PtGOfBUoGuZi2iVKcennRuM3/dqbtbyikTgBVMYEhWpzRFzzpVeI6", "8522179952", new DateTime(2025, 3, 28, 13, 53, 4, 534, DateTimeKind.Local).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 70L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "manley@carter.us", "Tom Weimann", "$2a$11$Jctltqc9GLSksXgm1mDYo.xXp5XA4BWH0lVQckxWpR2VEKV5iyvNu", "8902223144", new DateTime(2025, 3, 28, 13, 53, 4, 669, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 71L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "kane@schiller.ca", "Prof. Henri Howe", false, "$2a$11$xSUy.GM31ps/EK0nYihyj.MM73AXbpGR9SPUCjufS6GQrysxhvHmG", "2035026111", new DateTime(2025, 3, 28, 13, 53, 4, 801, DateTimeKind.Local).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 72L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "stephania.hahn@marquardtjohns.biz", "Pedro Moore", "$2a$11$9ew6fRpWdDe6GzaZThU52uW59dbe3zETqOGmWbZ.tscrrFoZI6xY2", "8174366541", new DateTime(2025, 3, 28, 13, 53, 4, 932, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 73L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "ulices_effertz@rosenbaumzieme.us", "Cyril Hane", "$2a$11$w9e.FbKkzvHhhlVFAbGhIuYaP7zXTskuq1HbZTQxZQmYMyUgcCvvO", "1383404402", new DateTime(2025, 3, 28, 13, 53, 5, 63, DateTimeKind.Local).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 74L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "pamela_gislason@daniellangworth.com", "Ms. Roselyn Oran Maggio DVM", "$2a$11$oKi4WM/14tbO.CMDOjmwbeTV504dGLOVyA/1uXknNeRMIkwR2jyAa", "8383660241", new DateTime(2025, 3, 28, 13, 53, 5, 195, DateTimeKind.Local).AddTicks(4962) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 75L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "arlo.schulist@larkin.name", "Kenyatta Fritsch", "$2a$11$iGhhBvoaaGakBMJHwr.90e8Qn.usEDAwQRQmmn87Zj1oAW/uCz7V.", "1229269435", new DateTime(2025, 3, 28, 13, 53, 5, 327, DateTimeKind.Local).AddTicks(2585) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 76L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "ivy_ritchie@emmerich.uk", "June Gaylord I", "$2a$11$K1bf9uH5D0uzReirbRdakuOWj19Tser2Xc6LD4Hi.vZqSRWcbeeXi", "1163848399", new DateTime(2025, 3, 28, 13, 53, 5, 458, DateTimeKind.Local).AddTicks(6073) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 77L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "ned.streich@macejkovic.us", "Nikita Abe Kling III", false, "$2a$11$eiLieHNWJQ6jFu5WHNGqh.LOuqgTNXqOUxMZ7DGBDM7iVZcyO8me.", "8881412013", new DateTime(2025, 3, 28, 13, 53, 5, 595, DateTimeKind.Local).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 78L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "leslie@purdy.ca", "Otilia Mohr", "$2a$11$wYWnsof0qJpQuRrTZnX.oeReCfv7CVQXqRaNiF35Y2J.d5vPIt.N6", "9671276342", new DateTime(2025, 3, 28, 13, 53, 5, 727, DateTimeKind.Local).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 79L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "darryl@bergstrombreitenberg.name", "Miss Clemens Satterfield", true, "$2a$11$dZGOq9lANe4E9ekF7RhzweIZRD0FUp5D8PNYtl2vhw5RejNh8UHX.", "1561779893", new DateTime(2025, 3, 28, 13, 53, 5, 858, DateTimeKind.Local).AddTicks(8102) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 80L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "jaylin@weissnat.uk", "Miss Chase Swaniawski IV", false, "$2a$11$1aExvBq3F0s3.VvvW59FHORHYsKhkfhUba44jfOgu8CDawte3kPPu", "9960620639", new DateTime(2025, 3, 28, 13, 53, 5, 990, DateTimeKind.Local).AddTicks(1895) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 81L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "libby@grady.info", "Mrs. Cathryn Retta Skiles", true, "$2a$11$NPZe5HkwhSkDYZe/gD59n.cM/iKh7CFDDbQs9kDn.x3gBqAYsJaLy", "8559621804", new DateTime(2025, 3, 28, 13, 53, 6, 122, DateTimeKind.Local).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 82L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "tressa@beer.com", "Kenny Eliezer Huel DVM", false, "$2a$11$z7PlniDxcjSM/bm3P/.r9exQd6re/aaYyNTeVYp98WBGLDIXmgb9O", "2039715801", new DateTime(2025, 3, 28, 13, 53, 6, 255, DateTimeKind.Local).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 83L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "hassan@wiza.co.uk", "Grayson Yundt I", "$2a$11$e4ux29deyyHxYx9pcdQ4t.vCnecBfTDhlCcFlYRp/VXsTfzgm6vWC", "7397822936", new DateTime(2025, 3, 28, 13, 53, 6, 387, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 84L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "vladimir_hand@ledner.info", "Golda Hegmann", false, "$2a$11$7eQ24qHdCKJHLXJVqqu/ZutYs6vfsaONUcS4S1hNQq9xd.1H3TNju", "9128601971", new DateTime(2025, 3, 28, 13, 53, 6, 518, DateTimeKind.Local).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 85L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "kayley.rempel@schamberger.info", "Everardo Ward", "$2a$11$OY.316z14RVNtVQYXQ3AKeB7W5vi9l8UUeVFqqKQGMmwoBY60SKGm", "9541331287", new DateTime(2025, 3, 28, 13, 53, 6, 650, DateTimeKind.Local).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 86L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "jerrod_windler@nitzsche.biz", "Hazel Jacobi", "$2a$11$9d07XPEoHfdc6bXzXc3qduy7lxYTjevtlzJsjqTrrTAojDAqZvJPS", "7121573721", new DateTime(2025, 3, 28, 13, 53, 6, 782, DateTimeKind.Local).AddTicks(1502) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 87L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "bernadine@nicolas.us", "Kyleigh Alberta Hills III", true, "$2a$11$SnRiNP2STaj9upRIFbtQpef2F08OP8T8UAViIc6i/SjUcMoitDALy", "1183282086", new DateTime(2025, 3, 28, 13, 53, 6, 913, DateTimeKind.Local).AddTicks(3957) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 88L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "audie@hoegerrutherford.uk", "Precious Kunde", false, "$2a$11$Y7e/wyrEt0sDOuRI/CriPO4ssR.LEh2GCpNKe/OwmGaa7R76xeZOK", "9235895291", new DateTime(2025, 3, 28, 13, 53, 7, 44, DateTimeKind.Local).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 89L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "ernestina.trantow@bednar.biz", "Lydia Leannon", "$2a$11$0xMo/836VJ3vsiazWaj.tum526Z9SXRSZWyierg9veMP87DhKpKI6", "9639668130", new DateTime(2025, 3, 28, 13, 53, 7, 177, DateTimeKind.Local).AddTicks(186) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 90L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "joana.lynch@langosh.uk", "Ibrahim Jaskolski", true, "$2a$11$cQxbyMHY578hxxbceZhZxOH1VlbSKJb6rIlRixiLTWY5FSdJ8u.o2", "1130611525", new DateTime(2025, 3, 28, 13, 53, 7, 311, DateTimeKind.Local).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 91L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "alfreda@streichschimmel.info", "Halle Trantow", "$2a$11$ybTQAuVBTcVVzBI.Y1BG8eXjgx7Do30jsfHEA2fbRhNlS07sgMvOW", "6951108307", new DateTime(2025, 3, 28, 13, 53, 7, 443, DateTimeKind.Local).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 92L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "destany@gleichner.biz", "Mr. Alan Hildegard Rogahn", true, "$2a$11$dncMYckbqQTUSj7CX4UNYO3GbsOx8gLzH8ZzY3cy6w2sacPCHKZZy", "9208116536", new DateTime(2025, 3, 28, 13, 53, 7, 574, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 93L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "celestino_jerde@rippinadams.biz", "Margarete Effertz", "$2a$11$d4kA0jSYI9m8i.4xY1BqWujGINcC1dsVhuATlWr91/252ZhVn/QhK", "9280376624", new DateTime(2025, 3, 28, 13, 53, 7, 706, DateTimeKind.Local).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 94L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "elwin.braun@jakubowskicronin.us", "Mackenzie Kendall Witting II", false, "$2a$11$I.gNRQeXgYt3u/1yuFnaTeIArT0OrW04TzupZo/XSmb6ondorX.Ly", "1338505559", new DateTime(2025, 3, 28, 13, 53, 7, 838, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 95L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "tia@schimmel.info", "Edison Jacobson", "$2a$11$RyZnLebIcp9bjRlRXGMl9uBiS6Q7xSM/P41dnqLtErS7i9vbC8A.O", "7021441803", new DateTime(2025, 3, 28, 13, 53, 7, 970, DateTimeKind.Local).AddTicks(7984) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 96L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "laisha@heathcote.info", "Loyce King MD", "$2a$11$C77kQEL3Rf.arMimYcaGdeHAXuXvC4KTBgrhKl3SOq6dGT1N.MTXe", "7131677545", new DateTime(2025, 3, 28, 13, 53, 8, 102, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 97L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "nina@tillman.ca", "Emmanuel Jacey Schamberger V", "$2a$11$miqsoRVMFp0YQm.VJkSNcux313BI5w0/1y.mWkFUJay4Cr1l74UPi", "1919448879", new DateTime(2025, 3, 28, 13, 53, 8, 234, DateTimeKind.Local).AddTicks(4509) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 98L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "heloise@tillman.name", "Amaya Upton", false, "$2a$11$w2QssUmtQxb3do5Ih5Rfyei7shAYC.t2kapgfTuJ5QKy6RCxzFuDO", "8277702418", new DateTime(2025, 3, 28, 13, 53, 8, 366, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 99L,
                columns: new[] { "Email", "FullName", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "alivia@koelpinbauch.com", "Keon Murphy", "$2a$11$cCz7fqODCx1JBOuUO48DEuAm9aBgFPLnlCLPHBBdnxff0v9GqERw.", "7903087134", new DateTime(2025, 3, 28, 13, 53, 8, 497, DateTimeKind.Local).AddTicks(7124) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 100L,
                columns: new[] { "Email", "FullName", "Gender", "Password", "Phone", "UpdatedAt" },
                values: new object[] { "paula@hanewalsh.uk", "Kaylin Ethelyn Lang IV", true, "$2a$11$YK6jxLQSgAf3x6mAve1Y4u1Ehl4eq84h/RV2w6xKdVIA5jFnsXSi.", "7648738587", new DateTime(2025, 3, 28, 13, 53, 8, 629, DateTimeKind.Local).AddTicks(2791) });
        }
    }
}
