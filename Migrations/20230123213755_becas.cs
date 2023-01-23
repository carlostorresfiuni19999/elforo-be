using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace elforo_be.Migrations
{
    public partial class becas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33bc2465-4a42-4023-8e71-db3c488ea126");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76a0c33f-f192-4376-b5e8-7cf6465b696d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f38ff817-894e-472a-9c3d-5493c6340ea8");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Apellido", "ConcurrencyStamp", "Doc", "Email", "EmailConfirmed", "Ingreso", "LockoutEnabled", "LockoutEnd", "Nacimiento", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "33bc2465-4a42-4023-8e71-db3c488ea126", 0, "Kikuchi Yamamoto", "16b197e2-c66c-47f3-8527-df2269e25891", null, "Erik.Kikuchi123@mail.com", false, new DateOnly(2018, 7, 13), false, null, new DateOnly(1999, 1, 1), "Erik Kaito", "ERIK.KIKUCHI123@MAIL.COM", null, null, null, false, "81ddaa62-c0db-4dca-bc48-d2f3c3cb3a58", false, null },
                    { "76a0c33f-f192-4376-b5e8-7cf6465b696d", 0, "Trinidad Ocampos", "d4fe9deb-a704-44a0-80ce-72b016f1edbf", null, "Abel.Trinidad123@mail.com", false, new DateOnly(2019, 7, 15), false, null, new DateOnly(2000, 1, 1), "Demetrio Abel", "ABEL.TRINIDAD123@MAIL.COM", null, null, null, false, "d74db54d-261c-4ffe-8c89-9724e8b9a45c", false, null },
                    { "f38ff817-894e-472a-9c3d-5493c6340ea8", 0, "Torres", "debdc3ae-03bb-4167-9cec-6f5d29243052", null, "Carlos.Torres123@mail.com", false, new DateOnly(2018, 7, 13), false, null, new DateOnly(1999, 7, 10), "Carlos", "CARLOS.TORRES@123MAIL.COM", null, "AQAAAAEAACcQAAAAEP8+rM16USylGUavE3iwdbBpnclM6BPjZht91tTqSdMsYFOcVxwAdWVusSvpxPRskA==", null, false, "a2de3306-7ec8-42b6-b594-db3269891f8f", false, "Carlos.Torres123@mail.com" }
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
    }
}
