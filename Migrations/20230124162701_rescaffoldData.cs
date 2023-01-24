using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace elforo_be.Migrations
{
    public partial class rescaffoldData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3cfb9e51-a50e-41f4-b43c-b50a61095e7c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a57c250-bade-4c28-9704-a6b70306f321");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5719520-8b53-48c7-9b13-98bbc79ef9b2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "3cfb9e51-a50e-41f4-b43c-b50a61095e7c", 0, "Trinidad Ocampos", "c086ac03-52aa-4f23-85b1-7b99797de23e", null, "Abel.Trinidad123@mail.com", false, new DateOnly(2019, 7, 15), false, null, new DateOnly(2000, 1, 1), "Demetrio Abel", "ABEL.TRINIDAD123@MAIL.COM", null, "AQAAAAEAACcQAAAAEC+jYn+hQuekRQ0fO7m5CKkMnhjw/Y2k8MHAGJU4TvjdfdxIl27Jhx5TNRbBRNxZFg==", null, false, "76e180a8-8b2f-4f7b-a27b-65443003f49a", false, null },
                    { "8a57c250-bade-4c28-9704-a6b70306f321", 0, "Kikuchi Yamamoto", "e11674ad-b6b0-4b26-840d-726f109c14c3", null, "Erik.Kikuchi123@mail.com", false, new DateOnly(2018, 7, 13), false, null, new DateOnly(1999, 1, 1), "Erik Kaito", "ERIK.KIKUCHI123@MAIL.COM", null, "AQAAAAEAACcQAAAAEOmhxyNDOBt3cpMKjQl8tYIBqZ+YVKW1psp/E8Ks0TSH4pwijTMr3/wAXvtROqbU5Q==", null, false, "de93c605-11c5-4851-8055-1f293432adfa", false, null },
                    { "b5719520-8b53-48c7-9b13-98bbc79ef9b2", 0, "Torres", "d3f0b077-dfd4-4f09-b6f9-6e14dff2f3c8", null, "Carlos.Torres123@mail.com", false, new DateOnly(2018, 7, 13), false, null, new DateOnly(1999, 7, 10), "Carlos", "CARLOS.TORRES@123MAIL.COM", null, "AQAAAAEAACcQAAAAEDaYNUfedloqxfoiOsXuzJ9PEO+wZqlGKAl5PCujdW9NfEu68kihBm4cnShM4w92NA==", null, false, "19172422-f628-428e-a946-547f07bbe6e7", false, "Carlos.Torres123@mail.com" }
                });
        }
    }
}
