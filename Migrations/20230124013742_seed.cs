using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace elforo_be.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Apellido", "ConcurrencyStamp", "Doc", "Email", "EmailConfirmed", "Ingreso", "LockoutEnabled", "LockoutEnd", "Nacimiento", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "543045f8-001e-419a-8820-7a197d9d7cce", 0, "Trinidad Ocampos", "1f63731e-be83-473e-8de0-0bd312d474ef", null, "Abel.Trinidad123@mail.com", false, new DateOnly(2019, 7, 15), false, null, new DateOnly(2000, 1, 1), "Demetrio Abel", "ABEL.TRINIDAD123@MAIL.COM", null, "AQAAAAEAACcQAAAAEFuJ98OQs+GqwIaGITe5CI6VvkHmXRUSn7Hj9aPG7o8fs/vPwqwZWu3q+MmhqPOE+Q==", null, false, "fe749019-396a-433b-b565-13d7c0653f22", false, null },
                    { "9318c65e-ec01-460d-a951-2a1efdbef3ae", 0, "Torres", "37165c4c-66e7-484c-8d5b-6423ae6b3c40", null, "Carlos.Torres123@mail.com", false, new DateOnly(2018, 7, 13), false, null, new DateOnly(1999, 7, 10), "Carlos", "CARLOS.TORRES@123MAIL.COM", null, "AQAAAAEAACcQAAAAEP0Ouno8bznk0bCySfk/YJ4iUW/458SZgrz8oagpaYNorRwrT9v6tJBaE/Dn0FRlhQ==", null, false, "515476f0-952b-4ed7-b126-9612908555e7", false, "Carlos.Torres123@mail.com" },
                    { "d93d0352-ee00-48c7-81f7-4d5661f9bb41", 0, "Kikuchi Yamamoto", "3028c3fa-6476-437f-bc03-f57ba5a60ae7", null, "Erik.Kikuchi123@mail.com", false, new DateOnly(2018, 7, 13), false, null, new DateOnly(1999, 1, 1), "Erik Kaito", "ERIK.KIKUCHI123@MAIL.COM", null, "AQAAAAEAACcQAAAAEH5sBUn4YhuI1zbhM/qKjGLtZkbJ93IrRTZjR2BfqGhn8wPTI07Bg3Hoqp5EXX5vrQ==", null, false, "8274d075-efa3-48b0-9294-2ad67760d831", false, null }
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
                keyValue: "543045f8-001e-419a-8820-7a197d9d7cce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9318c65e-ec01-460d-a951-2a1efdbef3ae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d93d0352-ee00-48c7-81f7-4d5661f9bb41");

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
