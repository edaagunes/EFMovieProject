using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFProject.Migrations
{
    /// <inheritdoc />
    public partial class ActorHasDataRemoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "ef",
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("358f6fb7-38d5-4511-bae6-3a66a833668e"));

            migrationBuilder.DeleteData(
                schema: "ef",
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("36da875d-d505-4805-ac15-331c77f80787"));

            migrationBuilder.DeleteData(
                schema: "ef",
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("3bb613cf-deab-4719-92b2-54647c405f31"));

            migrationBuilder.DeleteData(
                schema: "ef",
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("5119f8e7-6e4e-4828-b063-a47555465aba"));

            migrationBuilder.DeleteData(
                schema: "ef",
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("525a13ad-b645-4f00-ad4b-4a4ca2f25779"));

            migrationBuilder.DeleteData(
                schema: "ef",
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("8ed4dcc5-cd4f-4a30-8398-7a54f8a660fe"));

            migrationBuilder.DeleteData(
                schema: "ef",
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("b43e34c5-bd33-431f-bb8c-a48ee5343be0"));

            migrationBuilder.DeleteData(
                schema: "ef",
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("b5d5dc12-9088-4d89-8eb1-26bc2d867fd7"));

            migrationBuilder.DeleteData(
                schema: "ef",
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("b623921c-b69f-4fd9-94cf-b60c81b1f131"));

            migrationBuilder.DeleteData(
                schema: "ef",
                table: "Actors",
                keyColumn: "Id",
                keyValue: new Guid("bf4f2ee8-8014-4cd9-bd57-dec931137a70"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "ef",
                table: "Actors",
                columns: new[] { "Id", "CreatedDate", "FirstName", "LastName", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("358f6fb7-38d5-4511-bae6-3a66a833668e"), new DateTime(2022, 2, 24, 3, 36, 56, 660, DateTimeKind.Local).AddTicks(7118), "Bilgekutluk", "Yeşilkaya", new DateTime(2024, 3, 3, 22, 52, 56, 708, DateTimeKind.Local).AddTicks(5503) },
                    { new Guid("36da875d-d505-4805-ac15-331c77f80787"), new DateTime(2021, 8, 16, 9, 37, 3, 234, DateTimeKind.Local).AddTicks(9913), "Bekeç", "Taşçı", new DateTime(2023, 12, 25, 7, 55, 3, 787, DateTimeKind.Local).AddTicks(9316) },
                    { new Guid("3bb613cf-deab-4719-92b2-54647c405f31"), new DateTime(2021, 8, 20, 20, 41, 40, 353, DateTimeKind.Local).AddTicks(2320), "Atakağan", "Aykaç", new DateTime(2023, 9, 2, 12, 46, 4, 258, DateTimeKind.Local).AddTicks(7118) },
                    { new Guid("5119f8e7-6e4e-4828-b063-a47555465aba"), new DateTime(2023, 7, 30, 1, 25, 27, 220, DateTimeKind.Local).AddTicks(9849), "Baymünke", "Tanrıkulu", new DateTime(2023, 9, 29, 21, 37, 17, 591, DateTimeKind.Local).AddTicks(4515) },
                    { new Guid("525a13ad-b645-4f00-ad4b-4a4ca2f25779"), new DateTime(2024, 8, 14, 8, 6, 43, 323, DateTimeKind.Local).AddTicks(2330), "Arsıl", "Pektemek", new DateTime(2023, 3, 19, 3, 21, 19, 506, DateTimeKind.Local).AddTicks(6132) },
                    { new Guid("8ed4dcc5-cd4f-4a30-8398-7a54f8a660fe"), new DateTime(2022, 4, 22, 3, 59, 2, 237, DateTimeKind.Local).AddTicks(5325), "Gökçe", "Tanrıkulu", new DateTime(2024, 2, 26, 5, 4, 37, 790, DateTimeKind.Local).AddTicks(81) },
                    { new Guid("b43e34c5-bd33-431f-bb8c-a48ee5343be0"), new DateTime(2022, 4, 29, 19, 2, 4, 34, DateTimeKind.Local).AddTicks(1444), "Bilgekan", "Yıldızoğlu", new DateTime(2024, 6, 13, 11, 35, 35, 764, DateTimeKind.Local).AddTicks(146) },
                    { new Guid("b5d5dc12-9088-4d89-8eb1-26bc2d867fd7"), new DateTime(2023, 3, 31, 14, 56, 34, 12, DateTimeKind.Local).AddTicks(7667), "Alparsbeğ", "Menemencioğlu", new DateTime(2024, 11, 18, 23, 58, 26, 621, DateTimeKind.Local).AddTicks(8092) },
                    { new Guid("b623921c-b69f-4fd9-94cf-b60c81b1f131"), new DateTime(2024, 9, 6, 2, 10, 35, 985, DateTimeKind.Local).AddTicks(7923), "Bolsun", "Ozansoy", new DateTime(2023, 2, 19, 23, 11, 53, 966, DateTimeKind.Local).AddTicks(8966) },
                    { new Guid("bf4f2ee8-8014-4cd9-bd57-dec931137a70"), new DateTime(2021, 2, 12, 3, 1, 12, 658, DateTimeKind.Local).AddTicks(1607), "Cebe", "Aşıkoğlu", new DateTime(2023, 4, 19, 11, 18, 26, 387, DateTimeKind.Local).AddTicks(9600) }
                });
        }
    }
}
