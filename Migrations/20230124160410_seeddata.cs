using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace elforo_be.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Apellido", "ConcurrencyStamp", "Doc", "Email", "EmailConfirmed", "Ingreso", "LockoutEnabled", "LockoutEnd", "Nacimiento", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "340c1934-8b05-40a6-9427-bc03b738c158", 0, "Kikuchi Yamamoto", "a1714ea1-9a2d-4e70-812d-68d28faf0e8b", null, "Erik.Kikuchi123@mail.com", false, new DateOnly(2018, 7, 13), false, null, new DateOnly(1999, 1, 1), "Erik Kaito", "ERIK.KIKUCHI123@MAIL.COM", null, "AQAAAAEAACcQAAAAEAeWS7MRFcWKZQuJPn4zrLfzFURxT4NV9wsLsAkhkGrbHa4HJE+66xcHI0WEHoURrg==", null, false, "2a08fcad-6805-45c4-bc67-a06c09882f90", false, null },
                    { "475d5835-d31c-403b-8d73-046b0e082969", 0, "Torres", "4b27bf08-6ad4-4a4e-a6fb-dca1c5a8aa68", null, "Carlos.Torres123@mail.com", false, new DateOnly(2018, 7, 13), false, null, new DateOnly(1999, 7, 10), "Carlos", "CARLOS.TORRES@123MAIL.COM", null, "AQAAAAEAACcQAAAAELqwwrGmPhKnJ0yWFhoOfwKO9uxV9BRyRaRWztgmAwj992eAuHwe7eYaZpw1ZismXw==", null, false, "9265feb0-aaf6-4242-ae79-27c78b8de984", false, "Carlos.Torres123@mail.com" },
                    { "e54cfda3-ac92-44a4-8bc1-a7c7f515a379", 0, "Trinidad Ocampos", "5f67ce03-d047-4623-b5a8-fdcc4c2c649b", null, "Abel.Trinidad123@mail.com", false, new DateOnly(2019, 7, 15), false, null, new DateOnly(2000, 1, 1), "Demetrio Abel", "ABEL.TRINIDAD123@MAIL.COM", null, "AQAAAAEAACcQAAAAEJ0bBGJdedOyQ+sNziN6tHSvcMjPmKUbajUtL1Xvm5KSh+O5iSc+0lX5Gx8MyusZAQ==", null, false, "cef1e90b-411b-476b-a482-2064abd72a4a", false, null }
                });

            migrationBuilder.InsertData(
                table: "Becas",
                columns: new[] { "Id", "Descripcion", "NombreBeca" },
                values: new object[,]
                {
                    { 1, "Beca disponibles para alumnos con promedio igual o mayor a 3.5", "Beca de la UNI" },
                    { 2, "Beca de movilidad a Kansas para alumnos del ultimo semestre", "Beca de movilidad" },
                    { 3, "Monto de 2500000, para alumnos de la promo 2022 y 2023", "Beca de Itaipu" }
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
                keyValue: "340c1934-8b05-40a6-9427-bc03b738c158");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "475d5835-d31c-403b-8d73-046b0e082969");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e54cfda3-ac92-44a4-8bc1-a7c7f515a379");

            migrationBuilder.DeleteData(
                table: "Becas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Becas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Becas",
                keyColumn: "Id",
                keyValue: 3);

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
    }
}
