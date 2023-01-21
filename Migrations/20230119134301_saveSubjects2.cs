using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace elforo_be.Migrations
{
    public partial class saveSubjects2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { "66e4fb3e-fe0e-4376-a4ba-4fea231700c8", 0, "Trinidad Ocampos", "811027e9-b8fd-471d-b051-693d524dca4d", null, "Abel.Trinidad123@mail.com", false, new DateOnly(2019, 7, 15), false, null, new DateOnly(2000, 1, 1), "Demetrio Abel", "ABEL.TRINIDAD123@MAIL.COM", null, null, null, false, "62d5d3f6-78de-4cee-b89c-342f820a890e", false, null },
                    { "8638cb07-8b5d-4bdf-a688-82ce6e8b6677", 0, "Torres", "da0e0ed8-7f65-48b0-83b4-577061bc73dd", null, "Carlos.Torres123@mail.com", false, new DateOnly(2018, 7, 13), false, null, new DateOnly(1999, 7, 10), "Carlos", "CARLOS.TORRES@123MAIL.COM", null, "AQAAAAEAACcQAAAAEHuzq20rBZRB3GEOLWBEBUnqf0zfAZs82BrbbMHSskMSTiPaX5s7lV2mSHYIk5Zw+g==", null, false, "4f7866cc-7fea-493b-b046-2b792a09cf9c", false, "Carlos.Torres123@mail.com" },
                    { "87e44ccf-414d-408f-9239-781a5ca9330d", 0, "Kikuchi Yamamoto", "e2893c02-f606-4957-81b8-77cc5913a56d", null, "Erik.Kikuchi123@mail.com", false, new DateOnly(2018, 7, 13), false, null, new DateOnly(1999, 1, 1), "Erik Kaito", "ERIK.KIKUCHI123@MAIL.COM", null, null, null, false, "f70bcebf-48ac-4f0c-afdf-5648bbfa2280", false, null }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "PF", "PP", "Score", "UserId", "Year" },
                values: new object[,]
                {
                    { 1, "Interaccion Hombre Maquina", 59, 71, 1, null, new DateOnly(2022, 12, 21) },
                    { 2, "Analisis Matematico III", 91, 80, 5, null, new DateOnly(2022, 12, 21) },
                    { 3, "Fisica III", 82, 95, 4, null, new DateOnly(2022, 12, 23) },
                    { 4, "Diseño Digital", 73, 81, 3, null, new DateOnly(2023, 1, 10) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66e4fb3e-fe0e-4376-a4ba-4fea231700c8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8638cb07-8b5d-4bdf-a688-82ce6e8b6677");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87e44ccf-414d-408f-9239-781a5ca9330d");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4);

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
    }
}
