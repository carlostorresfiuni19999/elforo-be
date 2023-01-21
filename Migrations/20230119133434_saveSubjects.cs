using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace elforo_be.Migrations
{
    public partial class saveSubjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c8baf5ee-3eec-4d2e-9340-ff894a60ca77");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Apellido", "ConcurrencyStamp", "Doc", "Email", "EmailConfirmed", "Ingreso", "LockoutEnabled", "LockoutEnd", "Nacimiento", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "16d55e1f-fc90-4ad4-b070-739b4c97e26a", 0, "Kikuchi Yamamoto", "5e9b87ec-a2c1-4385-a57c-45c8d6c20b08", null, "Erik.Kikuchi123@mail.com", false, new DateOnly(2018, 7, 13), false, null, new DateOnly(1999, 1, 1), "Erik Kaito", "ERIK.KIKUCHI123@MAIL.COM", null, null, null, false, "735857e4-f79b-4ba1-ba3e-f13d86d474ea", false, null },
                    { "1ddf8687-cf58-47b0-a794-0ed30eb1d025", 0, "Trinidad Ocampos", "8907b281-eb2e-4c78-b56e-f44889f24bf0", null, "Abel.Trinidad123@mail.com", false, new DateOnly(2019, 7, 15), false, null, new DateOnly(2000, 1, 1), "Demetrio Abel", "ABEL.TRINIDAD123@MAIL.COM", null, null, null, false, "2c5ba807-8603-4555-a4d0-ef015b2598d0", false, null },
                    { "82667594-5cd5-4cd3-91f0-74241feec1af", 0, "Torres", "2c4cbe12-e454-4f1b-9c34-de4ac3b3a024", null, "Carlos.Torres123@mail.com", false, new DateOnly(2018, 7, 13), false, null, new DateOnly(1999, 7, 10), "Carlos", "CARLOS.TORRES@123MAIL.COM", null, "AQAAAAEAACcQAAAAECbZFYO5sUofHuAR32REfJwD8+2/fd7LUVKRfDGo/d/Wpa/8JV1e3OT7wJ3UaCi5Gw==", null, false, "e7697931-cd1e-484a-8e11-e033505510bb", false, "Carlos.Torres123@mail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16d55e1f-fc90-4ad4-b070-739b4c97e26a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ddf8687-cf58-47b0-a794-0ed30eb1d025");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82667594-5cd5-4cd3-91f0-74241feec1af");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Apellido", "ConcurrencyStamp", "Doc", "Email", "EmailConfirmed", "Ingreso", "LockoutEnabled", "LockoutEnd", "Nacimiento", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c8baf5ee-3eec-4d2e-9340-ff894a60ca77", 0, "Torres", "19147e15-63a7-4046-8807-d8f2c2381d5c", null, "Carlos.Torres123@mail.com", false, new DateOnly(2018, 7, 13), false, null, new DateOnly(1999, 7, 10), "Carlos", "CARLOS.TORRES@123MAIL.COM", null, "AQAAAAEAACcQAAAAEP0nDGu/5UBvpZKs2wlDFYV6Ey5Mg2kpoisjydLFnrOmYYd14LkLuNA0jaFuu+QSLA==", null, false, "59d35c35-f4ce-416b-ae3c-e74e1eff4f87", false, "Carlos.Torres123@mail.com" });
        }
    }
}
