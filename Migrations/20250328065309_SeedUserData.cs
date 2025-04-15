using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineLearning.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AITrainingData",
                keyColumn: "DataId",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AITrainingData",
                keyColumn: "DataId",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 28, 13, 27, 15, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 28, 13, 27, 15, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 28, 13, 27, 15, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 28, 13, 27, 15, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 28, 13, 27, 15, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 28, 13, 27, 15, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 28, 13, 27, 15, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 28, 13, 27, 15, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 28, 13, 27, 15, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 28, 13, 27, 15, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 28, 13, 27, 15, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 28, 13, 27, 15, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 28, 13, 27, 15, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 28, 13, 27, 15, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 28, 13, 27, 15, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 28, 13, 52, 55, 827, DateTimeKind.Local).AddTicks(5010), "1", new DateTime(2025, 3, 28, 13, 52, 55, 827, DateTimeKind.Local).AddTicks(5011) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 28, 13, 52, 55, 827, DateTimeKind.Local).AddTicks(5026), "1", new DateTime(2025, 3, 28, 13, 52, 55, 827, DateTimeKind.Local).AddTicks(5026) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "AvatarUrl", "CreatedAt", "DeletedAt", "Dob", "Email", "FullName", "Gender", "IsActived", "Password", "Phone", "UpdatedAt" },
                values: new object[,]
                {
                    { 3L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "jazmyne.kemmer@johnsonrunolfsson.us", "Lesly Langworth", true, true, "$2a$11$ZdM4GuLrTxG2aUW401/V7uTXyjALmTB6tTuJPJY9T3rKXrXped/Li", "7002940660", new DateTime(2025, 3, 28, 13, 52, 55, 827, DateTimeKind.Local).AddTicks(5034) },
                    { 4L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "marcella@murrayjenkins.uk", "Christelle Oberbrunner", true, true, "$2a$11$M4f/CflX.sQyBOHeRu6y4etI5tvx.TLW5CC2CdjQwmRX2oGx1Gq6y", "8648476843", new DateTime(2025, 3, 28, 13, 52, 55, 962, DateTimeKind.Local).AddTicks(7958) },
                    { 5L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "vernie.pollich@lynchroberts.us", "Prof. Katelyn Lucile Abbott V", true, true, "$2a$11$G4EfnwIIMA0unUaa48Dktu5v6KaY8o5RrYJ.qSLCwrZetc6PqT0/K", "7595119395", new DateTime(2025, 3, 28, 13, 52, 56, 97, DateTimeKind.Local).AddTicks(477) },
                    { 6L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "pedro_lowe@johns.biz", "Carmine Bernier", true, true, "$2a$11$YUuH1QR4p7rPvkwrfADKlORCukb2bjciK7ybdSTx6dzuqxCvz10D.", "9737207227", new DateTime(2025, 3, 28, 13, 52, 56, 229, DateTimeKind.Local).AddTicks(7528) },
                    { 7L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "liana.kirlin@dietrich.name", "Mr. Theresa Quigley", true, true, "$2a$11$gdfyojYSOWLmzUz6sHhYKOui35CyCTlS3zQNOlCaoCaVMTJRVoJb6", "7787036156", new DateTime(2025, 3, 28, 13, 52, 56, 361, DateTimeKind.Local).AddTicks(5092) },
                    { 8L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "lea@oconnell.info", "Aric Auer", false, true, "$2a$11$TpM17epq67CBsGwGV33EB.1Y2PI/Cy4zCPSZ3rNEtZ1aB4Trebe0G", "9991708034", new DateTime(2025, 3, 28, 13, 52, 56, 493, DateTimeKind.Local).AddTicks(7790) },
                    { 9L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "dustin_schiller@friesen.biz", "Jacey Bernier", false, true, "$2a$11$T621OjoFXwdNij6.o0O9T.ikB.Z/EEhWDJBz64rCUs92qteSRVVh.", "1040292516", new DateTime(2025, 3, 28, 13, 52, 56, 625, DateTimeKind.Local).AddTicks(5597) },
                    { 10L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "korey@ruecker.info", "Liliane Schultz", false, true, "$2a$11$zbfPW8zgesHAMscnV/ER1uBZ7GJD/2j7Lzw12849HN5z3BN5fh5Ti", "8103331129", new DateTime(2025, 3, 28, 13, 52, 56, 757, DateTimeKind.Local).AddTicks(1280) },
                    { 11L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "bette@altenwerthwhite.us", "Mrs. Drew Farrell MD", false, true, "$2a$11$Sw2x6oIyxIQbKDid9STY5uRbzDQqX.BVMKsoFZV5f28AuAYss9qAC", "8562818266", new DateTime(2025, 3, 28, 13, 52, 56, 888, DateTimeKind.Local).AddTicks(4345) },
                    { 12L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "louisa.reichel@lakin.co.uk", "Piper Kulas", true, true, "$2a$11$bIDx2O8ED3nXx.JQGX1WZOVEsKcigOYd39KrrX5uromw5iRvScB1q", "9936749016", new DateTime(2025, 3, 28, 13, 52, 57, 19, DateTimeKind.Local).AddTicks(5941) },
                    { 13L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "tessie_huel@lynch.name", "Mrs. Gerda Americo Mosciski V", true, true, "$2a$11$bHyOdYrDYDVi/J0SnBgzSOER8sTWtD3/VoDjwhL7Y76pCB7VPrR56", "9504766393", new DateTime(2025, 3, 28, 13, 52, 57, 151, DateTimeKind.Local).AddTicks(7634) },
                    { 14L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "reva_vonrueden@runte.ca", "Grace Alec Hickle I", true, true, "$2a$11$xBpD4fRwrVTAwONT/NQUMe4Vv3TLC67w2ULeCLoxKOYSE7/JMOk9W", "1719564465", new DateTime(2025, 3, 28, 13, 52, 57, 283, DateTimeKind.Local).AddTicks(4194) },
                    { 15L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "vivienne@bayer.co.uk", "Winona Harvey", false, true, "$2a$11$ldJ2njg.GBIT4std38PJgujV2XslH4Nu5Dt8PEBXgAKuBCuVL9XN2", "8514134675", new DateTime(2025, 3, 28, 13, 52, 57, 414, DateTimeKind.Local).AddTicks(5190) },
                    { 16L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "nicholaus@langworthreynolds.uk", "Mrs. Katelin Cremin", true, true, "$2a$11$VI3weZa.Og4u00Y6iaiFmeGtYyD0HmyoWIs4qp/BUuj0bv6vydMge", "9353582560", new DateTime(2025, 3, 28, 13, 52, 57, 546, DateTimeKind.Local).AddTicks(1965) },
                    { 17L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "isom_simonis@rice.biz", "Dakota Heathcote", true, true, "$2a$11$mZgi82yb1Fa.PZvzKbJmzujQe/wKeD2en/.mXPeK.VCAaG1uTMesS", "7653528053", new DateTime(2025, 3, 28, 13, 52, 57, 677, DateTimeKind.Local).AddTicks(8169) },
                    { 18L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "korbin@wyman.uk", "Thaddeus Schumm", true, true, "$2a$11$V7evTPSyppF4JHtmpclnFOhQhUJT/fnKTMUKpQ.wwevbIGqDExtHO", "6902583477", new DateTime(2025, 3, 28, 13, 52, 57, 809, DateTimeKind.Local).AddTicks(482) },
                    { 19L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "gerda.considine@kemmershields.name", "Juana Lindgren", true, true, "$2a$11$/ZNqf1Zv4xMLcx6iMB1snOsqeSRHWvnm2QYe9krs6WJAba9L4mpp.", "9134866426", new DateTime(2025, 3, 28, 13, 52, 57, 940, DateTimeKind.Local).AddTicks(3736) },
                    { 20L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "juanita.roob@kerluke.uk", "Dayana Hagenes", true, true, "$2a$11$DN5HliulbolpeYxHdGfIBeiBIrmeHVcMc7430DsOU9oH0KpQIYEhi", "1759961643", new DateTime(2025, 3, 28, 13, 52, 58, 71, DateTimeKind.Local).AddTicks(4463) },
                    { 21L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "annamae.grimes@wymanschneider.com", "Audie Gusikowski", false, true, "$2a$11$wGoUYr99nTSQpon08W0fYehw4mZtik1IP.68Zz5kRjFfVhjzhNyhm", "8678212914", new DateTime(2025, 3, 28, 13, 52, 58, 203, DateTimeKind.Local).AddTicks(2659) },
                    { 22L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "reece_boyer@smithamkris.ca", "Jennings Douglas", false, true, "$2a$11$oJqW1QiLYDMZvwcKGVRnE.GvL.24Uex9JbBAFYVhHAasqKc4dYciO", "8453281758", new DateTime(2025, 3, 28, 13, 52, 58, 335, DateTimeKind.Local).AddTicks(3187) },
                    { 23L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "colleen@gerlach.info", "Daniela Delfina Wyman Sr.", true, true, "$2a$11$n4UibTqmNYLtQJBLbs3Er.KHJ3Hzq6zwoQwp0LngB4zLq2WTgoX46", "8602774070", new DateTime(2025, 3, 28, 13, 52, 58, 466, DateTimeKind.Local).AddTicks(5291) },
                    { 24L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "mona@mclaughlin.us", "Marcelo Mertz", false, true, "$2a$11$/5lCpVDnxbK/cl3daCvaN.fqExIs5fjWzr9L6KNsI/s.eGzg.Yun6", "8829272930", new DateTime(2025, 3, 28, 13, 52, 58, 598, DateTimeKind.Local).AddTicks(2323) },
                    { 25L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "marcia@pagac.uk", "Mr. Maud Lew Herman IV", true, true, "$2a$11$6dmD0zPpygTpbd0zsJwJ8upWS.a.CYvXuWa77CtQ3qTueqwALCLrm", "9715987755", new DateTime(2025, 3, 28, 13, 52, 58, 730, DateTimeKind.Local).AddTicks(5367) },
                    { 26L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "jed.mertz@larkinschroeder.name", "Shirley Jaskolski", false, true, "$2a$11$DBPNYK.tb8rNEpK.Mbg1VuhAAo1PZhG8Fc6mOUXlPytd5VzojqeuK", "8987662042", new DateTime(2025, 3, 28, 13, 52, 58, 861, DateTimeKind.Local).AddTicks(9922) },
                    { 27L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "erika@crist.uk", "Marlee Swaniawski", true, true, "$2a$11$t5vuhbmmmyD8afU2Jek8MuUHl7hxEU.D4OwImp8tod6RLI9qzldwu", "7570696853", new DateTime(2025, 3, 28, 13, 52, 58, 995, DateTimeKind.Local).AddTicks(9545) },
                    { 28L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "ellie@bechtelar.biz", "Miss Sheridan Opal Effertz Jr.", false, true, "$2a$11$XCMDs0vfgh8/oXFY0aIZwuPMAtal7QetpQZwG/2D3O8iHZnz5UoNm", "2094280177", new DateTime(2025, 3, 28, 13, 52, 59, 127, DateTimeKind.Local).AddTicks(3228) },
                    { 29L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "stephanie@trantowwalter.com", "Isom Blick", false, true, "$2a$11$.Tnn000EGr.tf4U73u7FvuDima7do8V6MkYsLErgUWEPYrhhE13fi", "9334438022", new DateTime(2025, 3, 28, 13, 52, 59, 259, DateTimeKind.Local).AddTicks(801) },
                    { 30L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "jolie_stracke@franecki.us", "Maryse Romaguera", true, true, "$2a$11$GxkVJa4o7XBVKFJqRmtrYufuRv.SP9DVocXB1yM42u0Lcu7/me9UO", "1664119593", new DateTime(2025, 3, 28, 13, 52, 59, 390, DateTimeKind.Local).AddTicks(5826) },
                    { 31L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "travon_christiansen@kutchhoeger.us", "Jeremie Barton", false, true, "$2a$11$ctx80AW1f2Wy8bRuj9wn9udI35EXfXeDbNEAFBFyP.w3AGH2xv316", "8893615701", new DateTime(2025, 3, 28, 13, 52, 59, 522, DateTimeKind.Local).AddTicks(5057) },
                    { 32L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "nellie.goldner@lynch.uk", "Vance Hermiston", true, true, "$2a$11$ZibCf1OD9zeInlrB6TRmlesHcN5RPuSSIMJDq2U6qsfIajYwEvg3y", "8149002105", new DateTime(2025, 3, 28, 13, 52, 59, 653, DateTimeKind.Local).AddTicks(8294) },
                    { 33L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "myrtie@paucek.info", "Katarina Clark Weissnat IV", true, true, "$2a$11$/3AmMVAD4ORD9kCHAooOiOsgxzTdNeqayGQi5IGEDO0KlEYQnJsma", "7495887360", new DateTime(2025, 3, 28, 13, 52, 59, 785, DateTimeKind.Local).AddTicks(7506) },
                    { 34L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "layla.maggio@kutch.name", "Francesca Abshire", true, true, "$2a$11$90je6zqQ7pw6B5KehH.5IuPBmRv5dEERewbACJaGCu1rF/FtnuWiG", "8448374039", new DateTime(2025, 3, 28, 13, 52, 59, 917, DateTimeKind.Local).AddTicks(2960) },
                    { 35L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "edison@bechtelar.biz", "Melany VonRueden", true, true, "$2a$11$AAycQj6HDH0P3UsiQaHmMuqYOjw8l5VpamIU/i7AKsQUGyYU/nK76", "7151923038", new DateTime(2025, 3, 28, 13, 53, 0, 49, DateTimeKind.Local).AddTicks(435) },
                    { 36L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "madilyn@carter.com", "Ms. Dolores Kole Batz Sr.", true, true, "$2a$11$zROvXnfwPZMp78OYTspAvOY/zD9CQCXx.CGpcbhdUyJayb7UZLm.O", "6958306559", new DateTime(2025, 3, 28, 13, 53, 0, 180, DateTimeKind.Local).AddTicks(9189) },
                    { 37L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "elvie@townemurazik.us", "Mr. Nathan Dejon Parker II", true, true, "$2a$11$YU2JxWyWJEauBtfkmzpcfeBjGkVptI7exva3LA3qu2xMeNb.NkY2u", "8307557501", new DateTime(2025, 3, 28, 13, 53, 0, 312, DateTimeKind.Local).AddTicks(5768) },
                    { 38L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "percy@keebler.co.uk", "Jan Gorczany DDS", false, true, "$2a$11$DDejIRlFTBUj/5f56c/bMOqNVg83CIgFnzecmk5NeTtE1wQjwiMLS", "9206557399", new DateTime(2025, 3, 28, 13, 53, 0, 444, DateTimeKind.Local).AddTicks(3791) },
                    { 39L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "johathan.kautzer@tromp.ca", "Webster Mayert DDS", false, true, "$2a$11$6zHNKumbFbWcjj9WLSPdYu2Ys8zPGn7zppCe2HIDiC.fNoFfCf8z.", "7878291378", new DateTime(2025, 3, 28, 13, 53, 0, 576, DateTimeKind.Local).AddTicks(3712) },
                    { 40L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "lizzie_ziemann@jacobson.com", "Caitlyn Amiya Nicolas Sr.", true, true, "$2a$11$17GIdY15idjj/deRNYc2fuXN1m2UaQq2phqD3WwZ8tRhjFSgsZPlC", "8094415600", new DateTime(2025, 3, 28, 13, 53, 0, 708, DateTimeKind.Local).AddTicks(1319) },
                    { 41L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "prince_treutel@fritsch.name", "Miss Myrtis Lexi Pacocha", true, true, "$2a$11$6WlOFk/pq1.Tw4YI.YvdUec0rEE9jRW0/tUDwbmxXbokk.kLx/n46", "1240063278", new DateTime(2025, 3, 28, 13, 53, 0, 841, DateTimeKind.Local).AddTicks(8543) },
                    { 42L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "norval@mraz.uk", "Moshe Pacocha", false, true, "$2a$11$enm34kml0SkNC8H1lOGsueUTWlA/msYrQnsLMJEkwvk.B/LKR3IIi", "7550758535", new DateTime(2025, 3, 28, 13, 53, 0, 976, DateTimeKind.Local).AddTicks(2645) },
                    { 43L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "candelario.stanton@fahey.info", "Gabriel Fritsch", false, true, "$2a$11$v4l13repMwcaoTLBnud.Duth6qnPSGNMllyCE221dzHiOjl6KK0tu", "8177887386", new DateTime(2025, 3, 28, 13, 53, 1, 108, DateTimeKind.Local).AddTicks(6588) },
                    { 44L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "ron_reynolds@johnson.name", "Isabel Kozey", false, true, "$2a$11$frj1a7v9ZCLurx.47g68UeUWrgl3A5RO.iTdF8uJpsTkTV/gqCCaO", "8409078155", new DateTime(2025, 3, 28, 13, 53, 1, 240, DateTimeKind.Local).AddTicks(8434) },
                    { 45L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "ambrose.kihn@bartoletti.us", "Tod Cremin", true, true, "$2a$11$NwjUW8j0y5AScvxkTLWnG./pifVNTypkO1Ef5cCGm7ceRbk45arPC", "1284155859", new DateTime(2025, 3, 28, 13, 53, 1, 372, DateTimeKind.Local).AddTicks(3209) },
                    { 46L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "leanne@donnelly.biz", "Prof. Carson Ernser", false, true, "$2a$11$9OwxgkSqMfKupjgwsYT8yeIJ2tqJ/I9ClDwM1pg9wTlVMfz2o4Pya", "1930003004", new DateTime(2025, 3, 28, 13, 53, 1, 504, DateTimeKind.Local).AddTicks(2220) },
                    { 47L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "sierra.boyer@haley.info", "Edwina Langosh", true, true, "$2a$11$hBsNwloQ.ubI5Vrr9Ac6/OPIDrzcshTaY4nxoVLllLkE8ROcsCOKG", "1735009422", new DateTime(2025, 3, 28, 13, 53, 1, 635, DateTimeKind.Local).AddTicks(6998) },
                    { 48L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "jermain@volkman.us", "Yolanda Charlotte Luettgen II", false, true, "$2a$11$qqzdclAy6BTj5MbYEY4Dd.bbdPJxOxA2S7LBWCOPxg/RPFt46ndsS", "7958386307", new DateTime(2025, 3, 28, 13, 53, 1, 767, DateTimeKind.Local).AddTicks(7371) },
                    { 49L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "addison.pacocha@ohara.uk", "Lilla Weber", true, true, "$2a$11$KduA.YZ.U.VWDqnzLy8K3uDUOLCDYixXyYlZxetVtuC94.5U1bO3y", "1849792883", new DateTime(2025, 3, 28, 13, 53, 1, 899, DateTimeKind.Local).AddTicks(1967) },
                    { 50L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "elva@leuschkehudson.uk", "Demarco Lubowitz", true, true, "$2a$11$6iLCMynTd7NTxIQyTsgWBeAi6H0FpKWXiGm8KFwtMme1KvLImSunC", "7984056461", new DateTime(2025, 3, 28, 13, 53, 2, 30, DateTimeKind.Local).AddTicks(9195) },
                    { 51L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "oral.jerde@kuhlman.us", "Mr. Vivianne Branson Carter II", true, true, "$2a$11$msjbWKQw3qz93poZ1ydm1.2o590h1jzRyiiG4SdP5CGUt2t2d0OQq", "1934711330", new DateTime(2025, 3, 28, 13, 53, 2, 162, DateTimeKind.Local).AddTicks(6750) },
                    { 52L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "orland@johnsonshields.co.uk", "Everardo Gerhold", false, true, "$2a$11$vXQsKLCIUrxa1INT/cOwoea7ndO8RJsrtg6EzTdtVZeSo7WwZ1pW.", "1824337243", new DateTime(2025, 3, 28, 13, 53, 2, 294, DateTimeKind.Local).AddTicks(5545) },
                    { 53L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "mckayla@koelpin.com", "Ernesto Mante", true, true, "$2a$11$pk2UdS/YP9lGrN9rQagU8.jTOiZrxmDhw7cUg.Eofu4OWZ5QfAVBC", "7833168662", new DateTime(2025, 3, 28, 13, 53, 2, 426, DateTimeKind.Local).AddTicks(2874) },
                    { 54L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "alba@oconnerjones.us", "Estevan Rosenbaum", false, true, "$2a$11$mzqEbgvCWqpENtudi6WmEOkDP39rDP.YdRM9uyKGlLGA7/dbyzUFS", "6862252024", new DateTime(2025, 3, 28, 13, 53, 2, 558, DateTimeKind.Local).AddTicks(115) },
                    { 55L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "rosetta@hahn.info", "Carol Rau", false, true, "$2a$11$TG/E8QkKw0zXgj4VK5oLfOa2Bb65cyL/oCUOzboG1o6zQOB6.HiC2", "7569635212", new DateTime(2025, 3, 28, 13, 53, 2, 689, DateTimeKind.Local).AddTicks(8440) },
                    { 56L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "dexter.corwin@corwin.com", "Torrey Kirk Schuster Jr.", true, true, "$2a$11$bYW6FZFwZKhwZsxcft0N2.yFdAy7o2nTWNdAt2UOA/iM7BtUkfHEy", "6908831925", new DateTime(2025, 3, 28, 13, 53, 2, 821, DateTimeKind.Local).AddTicks(3043) },
                    { 57L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "remington_champlin@sauer.uk", "Sophia Vandervort", true, true, "$2a$11$XSBFWghUMs28P8gMEXSnKu5xbfXhHTcV/akG0xYikkga/bhjg/5sW", "8081886145", new DateTime(2025, 3, 28, 13, 53, 2, 952, DateTimeKind.Local).AddTicks(7227) },
                    { 58L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "erika@jewess.biz", "Lina Conroy", true, true, "$2a$11$cGMMB0X4K0/Xa6dasrhf6./98y3avCZyn4b6C/XmBwYPfJ0xRvgaa", "7508510318", new DateTime(2025, 3, 28, 13, 53, 3, 84, DateTimeKind.Local).AddTicks(6361) },
                    { 59L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "alicia.lesch@walshhaley.uk", "Addison Jayson Altenwerth DDS", true, true, "$2a$11$2g7TEnUG5CJw9DmDZYkqIuA7fVKzLa5mwGO6lkfEFCNqp5e08YRJu", "7317108154", new DateTime(2025, 3, 28, 13, 53, 3, 216, DateTimeKind.Local).AddTicks(3099) },
                    { 60L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "gabe_schneider@batz.uk", "Augustus Mann PhD", true, true, "$2a$11$egyz7kEF6SnAjM.AI1r3g.tQLLAzKhwMFrcs5zrJQjoH0JiyGQE2m", "9050901271", new DateTime(2025, 3, 28, 13, 53, 3, 348, DateTimeKind.Local).AddTicks(5860) },
                    { 61L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "leatha@bauch.biz", "Arianna Wolf", true, true, "$2a$11$G.Sik7BwJ1lBIzcuK27WNuVG6gzJqYnAx5B7yfPpl7yNUgXEvH9LW", "7394180636", new DateTime(2025, 3, 28, 13, 53, 3, 480, DateTimeKind.Local).AddTicks(419) },
                    { 62L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "nikko@stammdaniel.biz", "Elwin Bins", false, true, "$2a$11$o0V3McvwJaIviekEHn0BkuoLADKNrjP6aDCnm3xDyRkKDqKNc0FPu", "9797420138", new DateTime(2025, 3, 28, 13, 53, 3, 612, DateTimeKind.Local).AddTicks(1059) },
                    { 63L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "bret@hellerortiz.info", "Everardo Blanda", false, true, "$2a$11$2cmZTbP.JOZ8ed5BoGXhVOberkJKyy.0UysjsGkLxEkcAdP90qVsa", "9218174787", new DateTime(2025, 3, 28, 13, 53, 3, 743, DateTimeKind.Local).AddTicks(8013) },
                    { 64L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "rozella.volkman@andersonmoore.ca", "Nels Prosacco", false, true, "$2a$11$9CpsUxCtU7/cKAhwX/qKCOndZekQ5QUsLdQNKPjl4LI1WV3t65c8G", "7800838183", new DateTime(2025, 3, 28, 13, 53, 3, 875, DateTimeKind.Local).AddTicks(7796) },
                    { 65L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "urban_wisozk@volkmanfadel.com", "Dax Conn", true, true, "$2a$11$e//5TTw6ORrVH/05xYrm1OTVFy4ndZHl60aY/hq78VEHBzZYc5NeS", "6857735197", new DateTime(2025, 3, 28, 13, 53, 4, 7, DateTimeKind.Local).AddTicks(5970) },
                    { 66L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "joe@satterfieldschuster.com", "Lorna Robel", false, true, "$2a$11$ZEez7CPn1WCp2egS3z2J1uAj.X1Pr613/oWMkISLo/cyEphlsMo8m", "8606050639", new DateTime(2025, 3, 28, 13, 53, 4, 139, DateTimeKind.Local).AddTicks(9335) },
                    { 67L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "gia_dare@okeefedietrich.com", "Gabe Macejkovic", true, true, "$2a$11$n2vIDKtS2sqVyHIekWyd2.j7opz70sw3tFaudfckVQ5xauNbhk/b2", "7236807515", new DateTime(2025, 3, 28, 13, 53, 4, 271, DateTimeKind.Local).AddTicks(6800) },
                    { 68L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "arden@hesselpfeffer.us", "Laurel Lehner", true, true, "$2a$11$pcd2GuhF6JNr7a2zUoHtT.Id.lAa6DLRgCgpykXruvcBHQ5pzTi3e", "8669407335", new DateTime(2025, 3, 28, 13, 53, 4, 402, DateTimeKind.Local).AddTicks(5053) },
                    { 69L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "tyrel.gibson@cruickshankmitchell.biz", "Dorothea Lubowitz DDS", false, true, "$2a$11$PtGOfBUoGuZi2iVKcennRuM3/dqbtbyikTgBVMYEhWpzRFzzpVeI6", "8522179952", new DateTime(2025, 3, 28, 13, 53, 4, 534, DateTimeKind.Local).AddTicks(1588) },
                    { 70L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "manley@carter.us", "Tom Weimann", true, true, "$2a$11$Jctltqc9GLSksXgm1mDYo.xXp5XA4BWH0lVQckxWpR2VEKV5iyvNu", "8902223144", new DateTime(2025, 3, 28, 13, 53, 4, 669, DateTimeKind.Local).AddTicks(7084) },
                    { 71L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "kane@schiller.ca", "Prof. Henri Howe", false, true, "$2a$11$xSUy.GM31ps/EK0nYihyj.MM73AXbpGR9SPUCjufS6GQrysxhvHmG", "2035026111", new DateTime(2025, 3, 28, 13, 53, 4, 801, DateTimeKind.Local).AddTicks(3190) },
                    { 72L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "stephania.hahn@marquardtjohns.biz", "Pedro Moore", true, true, "$2a$11$9ew6fRpWdDe6GzaZThU52uW59dbe3zETqOGmWbZ.tscrrFoZI6xY2", "8174366541", new DateTime(2025, 3, 28, 13, 53, 4, 932, DateTimeKind.Local).AddTicks(6460) },
                    { 73L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "ulices_effertz@rosenbaumzieme.us", "Cyril Hane", false, true, "$2a$11$w9e.FbKkzvHhhlVFAbGhIuYaP7zXTskuq1HbZTQxZQmYMyUgcCvvO", "1383404402", new DateTime(2025, 3, 28, 13, 53, 5, 63, DateTimeKind.Local).AddTicks(7203) },
                    { 74L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "pamela_gislason@daniellangworth.com", "Ms. Roselyn Oran Maggio DVM", true, true, "$2a$11$oKi4WM/14tbO.CMDOjmwbeTV504dGLOVyA/1uXknNeRMIkwR2jyAa", "8383660241", new DateTime(2025, 3, 28, 13, 53, 5, 195, DateTimeKind.Local).AddTicks(4962) },
                    { 75L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "arlo.schulist@larkin.name", "Kenyatta Fritsch", true, true, "$2a$11$iGhhBvoaaGakBMJHwr.90e8Qn.usEDAwQRQmmn87Zj1oAW/uCz7V.", "1229269435", new DateTime(2025, 3, 28, 13, 53, 5, 327, DateTimeKind.Local).AddTicks(2585) },
                    { 76L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "ivy_ritchie@emmerich.uk", "June Gaylord I", true, true, "$2a$11$K1bf9uH5D0uzReirbRdakuOWj19Tser2Xc6LD4Hi.vZqSRWcbeeXi", "1163848399", new DateTime(2025, 3, 28, 13, 53, 5, 458, DateTimeKind.Local).AddTicks(6073) },
                    { 77L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "ned.streich@macejkovic.us", "Nikita Abe Kling III", false, true, "$2a$11$eiLieHNWJQ6jFu5WHNGqh.LOuqgTNXqOUxMZ7DGBDM7iVZcyO8me.", "8881412013", new DateTime(2025, 3, 28, 13, 53, 5, 595, DateTimeKind.Local).AddTicks(7775) },
                    { 78L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "leslie@purdy.ca", "Otilia Mohr", true, true, "$2a$11$wYWnsof0qJpQuRrTZnX.oeReCfv7CVQXqRaNiF35Y2J.d5vPIt.N6", "9671276342", new DateTime(2025, 3, 28, 13, 53, 5, 727, DateTimeKind.Local).AddTicks(7168) },
                    { 79L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "darryl@bergstrombreitenberg.name", "Miss Clemens Satterfield", true, true, "$2a$11$dZGOq9lANe4E9ekF7RhzweIZRD0FUp5D8PNYtl2vhw5RejNh8UHX.", "1561779893", new DateTime(2025, 3, 28, 13, 53, 5, 858, DateTimeKind.Local).AddTicks(8102) },
                    { 80L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "jaylin@weissnat.uk", "Miss Chase Swaniawski IV", false, true, "$2a$11$1aExvBq3F0s3.VvvW59FHORHYsKhkfhUba44jfOgu8CDawte3kPPu", "9960620639", new DateTime(2025, 3, 28, 13, 53, 5, 990, DateTimeKind.Local).AddTicks(1895) },
                    { 81L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "libby@grady.info", "Mrs. Cathryn Retta Skiles", true, true, "$2a$11$NPZe5HkwhSkDYZe/gD59n.cM/iKh7CFDDbQs9kDn.x3gBqAYsJaLy", "8559621804", new DateTime(2025, 3, 28, 13, 53, 6, 122, DateTimeKind.Local).AddTicks(870) },
                    { 82L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "tressa@beer.com", "Kenny Eliezer Huel DVM", false, true, "$2a$11$z7PlniDxcjSM/bm3P/.r9exQd6re/aaYyNTeVYp98WBGLDIXmgb9O", "2039715801", new DateTime(2025, 3, 28, 13, 53, 6, 255, DateTimeKind.Local).AddTicks(8887) },
                    { 83L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "hassan@wiza.co.uk", "Grayson Yundt I", false, true, "$2a$11$e4ux29deyyHxYx9pcdQ4t.vCnecBfTDhlCcFlYRp/VXsTfzgm6vWC", "7397822936", new DateTime(2025, 3, 28, 13, 53, 6, 387, DateTimeKind.Local).AddTicks(2102) },
                    { 84L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "vladimir_hand@ledner.info", "Golda Hegmann", false, true, "$2a$11$7eQ24qHdCKJHLXJVqqu/ZutYs6vfsaONUcS4S1hNQq9xd.1H3TNju", "9128601971", new DateTime(2025, 3, 28, 13, 53, 6, 518, DateTimeKind.Local).AddTicks(6091) },
                    { 85L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "kayley.rempel@schamberger.info", "Everardo Ward", false, true, "$2a$11$OY.316z14RVNtVQYXQ3AKeB7W5vi9l8UUeVFqqKQGMmwoBY60SKGm", "9541331287", new DateTime(2025, 3, 28, 13, 53, 6, 650, DateTimeKind.Local).AddTicks(3256) },
                    { 86L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "jerrod_windler@nitzsche.biz", "Hazel Jacobi", true, true, "$2a$11$9d07XPEoHfdc6bXzXc3qduy7lxYTjevtlzJsjqTrrTAojDAqZvJPS", "7121573721", new DateTime(2025, 3, 28, 13, 53, 6, 782, DateTimeKind.Local).AddTicks(1502) },
                    { 87L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "bernadine@nicolas.us", "Kyleigh Alberta Hills III", true, true, "$2a$11$SnRiNP2STaj9upRIFbtQpef2F08OP8T8UAViIc6i/SjUcMoitDALy", "1183282086", new DateTime(2025, 3, 28, 13, 53, 6, 913, DateTimeKind.Local).AddTicks(3957) },
                    { 88L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "audie@hoegerrutherford.uk", "Precious Kunde", false, true, "$2a$11$Y7e/wyrEt0sDOuRI/CriPO4ssR.LEh2GCpNKe/OwmGaa7R76xeZOK", "9235895291", new DateTime(2025, 3, 28, 13, 53, 7, 44, DateTimeKind.Local).AddTicks(8931) },
                    { 89L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "ernestina.trantow@bednar.biz", "Lydia Leannon", true, true, "$2a$11$0xMo/836VJ3vsiazWaj.tum526Z9SXRSZWyierg9veMP87DhKpKI6", "9639668130", new DateTime(2025, 3, 28, 13, 53, 7, 177, DateTimeKind.Local).AddTicks(186) },
                    { 90L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "joana.lynch@langosh.uk", "Ibrahim Jaskolski", true, true, "$2a$11$cQxbyMHY578hxxbceZhZxOH1VlbSKJb6rIlRixiLTWY5FSdJ8u.o2", "1130611525", new DateTime(2025, 3, 28, 13, 53, 7, 311, DateTimeKind.Local).AddTicks(5981) },
                    { 91L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "alfreda@streichschimmel.info", "Halle Trantow", true, true, "$2a$11$ybTQAuVBTcVVzBI.Y1BG8eXjgx7Do30jsfHEA2fbRhNlS07sgMvOW", "6951108307", new DateTime(2025, 3, 28, 13, 53, 7, 443, DateTimeKind.Local).AddTicks(495) },
                    { 92L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "destany@gleichner.biz", "Mr. Alan Hildegard Rogahn", true, true, "$2a$11$dncMYckbqQTUSj7CX4UNYO3GbsOx8gLzH8ZzY3cy6w2sacPCHKZZy", "9208116536", new DateTime(2025, 3, 28, 13, 53, 7, 574, DateTimeKind.Local).AddTicks(4577) },
                    { 93L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "celestino_jerde@rippinadams.biz", "Margarete Effertz", false, true, "$2a$11$d4kA0jSYI9m8i.4xY1BqWujGINcC1dsVhuATlWr91/252ZhVn/QhK", "9280376624", new DateTime(2025, 3, 28, 13, 53, 7, 706, DateTimeKind.Local).AddTicks(6922) },
                    { 94L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "elwin.braun@jakubowskicronin.us", "Mackenzie Kendall Witting II", false, true, "$2a$11$I.gNRQeXgYt3u/1yuFnaTeIArT0OrW04TzupZo/XSmb6ondorX.Ly", "1338505559", new DateTime(2025, 3, 28, 13, 53, 7, 838, DateTimeKind.Local).AddTicks(8775) },
                    { 95L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "tia@schimmel.info", "Edison Jacobson", true, true, "$2a$11$RyZnLebIcp9bjRlRXGMl9uBiS6Q7xSM/P41dnqLtErS7i9vbC8A.O", "7021441803", new DateTime(2025, 3, 28, 13, 53, 7, 970, DateTimeKind.Local).AddTicks(7984) },
                    { 96L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "laisha@heathcote.info", "Loyce King MD", true, true, "$2a$11$C77kQEL3Rf.arMimYcaGdeHAXuXvC4KTBgrhKl3SOq6dGT1N.MTXe", "7131677545", new DateTime(2025, 3, 28, 13, 53, 8, 102, DateTimeKind.Local).AddTicks(5830) },
                    { 97L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "nina@tillman.ca", "Emmanuel Jacey Schamberger V", true, true, "$2a$11$miqsoRVMFp0YQm.VJkSNcux313BI5w0/1y.mWkFUJay4Cr1l74UPi", "1919448879", new DateTime(2025, 3, 28, 13, 53, 8, 234, DateTimeKind.Local).AddTicks(4509) },
                    { 98L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "heloise@tillman.name", "Amaya Upton", false, true, "$2a$11$w2QssUmtQxb3do5Ih5Rfyei7shAYC.t2kapgfTuJ5QKy6RCxzFuDO", "8277702418", new DateTime(2025, 3, 28, 13, 53, 8, 366, DateTimeKind.Local).AddTicks(2880) },
                    { 99L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "alivia@koelpinbauch.com", "Keon Murphy", true, true, "$2a$11$cCz7fqODCx1JBOuUO48DEuAm9aBgFPLnlCLPHBBdnxff0v9GqERw.", "7903087134", new DateTime(2025, 3, 28, 13, 53, 8, 497, DateTimeKind.Local).AddTicks(7124) },
                    { 100L, "https://picsum.photos/200/200", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateOnly(2003, 6, 7), "paula@hanewalsh.uk", "Kaylin Ethelyn Lang IV", true, true, "$2a$11$YK6jxLQSgAf3x6mAve1Y4u1Ehl4eq84h/RV2w6xKdVIA5jFnsXSi.", "7648738587", new DateTime(2025, 3, 28, 13, 53, 8, 629, DateTimeKind.Local).AddTicks(2791) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 100L);

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
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7541), 2 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7550), 2 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7555), 2 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7559), 2 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7564), 2 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7573), 2 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7577), 2 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7582), 2 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7586), 2 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7592), 2 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 11L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7597), 2 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 12L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7601), 2 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 13L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7606), 2 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 14L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7610), 2 });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: 15L,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7615), 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(6828), "123456", new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(6844) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7016), "123456", new DateTime(2025, 3, 26, 20, 47, 58, 434, DateTimeKind.Local).AddTicks(7018) });
        }
    }
}
