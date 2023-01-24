using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace elforo_be.Migrations
{
    public partial class seedSubjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "877f89b9-dec2-490d-a305-b5f9cb2450a5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1bfef02-de83-4be9-b758-0f9e1bf31518");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb6d7eff-a0f5-4d3c-be15-b479eb82aab2");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Apellido", "ConcurrencyStamp", "Doc", "Email", "EmailConfirmed", "Ingreso", "LockoutEnabled", "LockoutEnd", "Nacimiento", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0317b93d-b17b-41f6-93a6-dc6280014b31", 0, "Torres", "83c747aa-202b-4c3c-9b37-68b1afa32b70", null, "Carlos.Torres123@mail.com", false, new DateOnly(2018, 7, 13), false, null, new DateOnly(1999, 7, 10), "Carlos", "CARLOS.TORRES@123MAIL.COM", null, "AQAAAAEAACcQAAAAEHVNiFm/l+9pHSakopqMMWWItLQDoC65jLWrU9avhpLxwM9cRHjlI0ULi5gwAktYRQ==", null, false, "e3857895-917d-4e50-b79c-caedb1f9321a", false, "Carlos.Torres123@mail.com" },
                    { "0df520bd-ddcd-4e99-a95c-6159eda7f187", 0, "Kikuchi Yamamoto", "a26e1649-47be-4b0c-b1fc-7bab1d8cc278", null, "Erik.Kikuchi123@mail.com", false, new DateOnly(2018, 7, 13), false, null, new DateOnly(1999, 1, 1), "Erik Kaito", "ERIK.KIKUCHI123@MAIL.COM", null, "AQAAAAEAACcQAAAAED7B4wRuQeQ4C5todlB8GWVFdY1V87LBZWjvapwnuuwfsGUdrUbjrgVYknm7kKVKOQ==", null, false, "b9ce8068-2049-401e-b1d9-77a449f28f25", false, null },
                    { "979d60d2-66b4-4448-9973-cf2bd4fbe505", 0, "Trinidad Ocampos", "bd7ffac4-c709-45b7-bf01-d462a1cca32a", null, "Abel.Trinidad123@mail.com", false, new DateOnly(2019, 7, 15), false, null, new DateOnly(2000, 1, 1), "Demetrio Abel", "ABEL.TRINIDAD123@MAIL.COM", null, "AQAAAAEAACcQAAAAECaSi1NLKyaVE+Lgtk4ZiAtiaWmVEJHgu/rQFnXFqQfUT1mGjklIRLvELbQJRxtaMg==", null, false, "d22a2a47-fc37-40eb-8a27-7693aed43809", false, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0317b93d-b17b-41f6-93a6-dc6280014b31");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0df520bd-ddcd-4e99-a95c-6159eda7f187");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "979d60d2-66b4-4448-9973-cf2bd4fbe505");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Apellido", "ConcurrencyStamp", "Doc", "Email", "EmailConfirmed", "Ingreso", "LockoutEnabled", "LockoutEnd", "Nacimiento", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "877f89b9-dec2-490d-a305-b5f9cb2450a5", 0, "Kikuchi Yamamoto", "da45da80-dfeb-49c1-8ccb-41a667140e01", null, "Erik.Kikuchi123@mail.com", false, new DateOnly(2018, 7, 13), false, null, new DateOnly(1999, 1, 1), "Erik Kaito", "ERIK.KIKUCHI123@MAIL.COM", null, "AQAAAAEAACcQAAAAEJyKe47hmNVds3XTAV5cY2r6MIBl4sasWZqio4xv8gmVIMjnyR2iiAYTIeTdyOLSiw==", null, false, "962e2867-c0ee-4d9e-837b-d0b903606ec8", false, null },
                    { "a1bfef02-de83-4be9-b758-0f9e1bf31518", 0, "Trinidad Ocampos", "83b2c6fe-89e8-4e5f-9e43-b7df1ab3e41d", null, "Abel.Trinidad123@mail.com", false, new DateOnly(2019, 7, 15), false, null, new DateOnly(2000, 1, 1), "Demetrio Abel", "ABEL.TRINIDAD123@MAIL.COM", null, "AQAAAAEAACcQAAAAELNCQmfuSUP54225UKj9bLnjzrtM6xCxkdvgqiGRTAzFc99rGZi8H3gS1GYt7cKRlg==", null, false, "4679b414-af05-4fb1-8757-a18b8c662563", false, null },
                    { "eb6d7eff-a0f5-4d3c-be15-b479eb82aab2", 0, "Torres", "a749f885-4106-441d-bdd3-15ba61c8c6b9", null, "Carlos.Torres123@mail.com", false, new DateOnly(2018, 7, 13), false, null, new DateOnly(1999, 7, 10), "Carlos", "CARLOS.TORRES@123MAIL.COM", null, "AQAAAAEAACcQAAAAEBTKcDNoL+c5EFNgbSIrIzBuLcNDgYrYSQsukK5gz2+y9mDFBxzXxHahnrKJkm+kdA==", null, false, "e55503f9-b0a5-4d4d-8ae8-9b165467ee4c", false, "Carlos.Torres123@mail.com" }
                });
        }
    }
}
