using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace elforo_be.Migrations
{
    public partial class alterQuestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d0e2508-eeed-41a2-a58e-991cb208c5be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4eff0a12-ba26-46c5-a652-10e8f900c85e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de236878-7a1f-473a-bdfe-30eab53efb6e");

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

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Questions",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Questions");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Apellido", "ConcurrencyStamp", "Doc", "Email", "EmailConfirmed", "Ingreso", "LockoutEnabled", "LockoutEnd", "Nacimiento", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1d0e2508-eeed-41a2-a58e-991cb208c5be", 0, "Torres", "62261d6d-0f90-454c-8270-59c154b4c5e2", null, "Carlos.Torres123@mail.com", false, new DateOnly(2018, 7, 13), false, null, new DateOnly(1999, 7, 10), "Carlos", "CARLOS.TORRES@123MAIL.COM", null, "AQAAAAEAACcQAAAAEK/jOe0KzhzeAcQ086eE6LmdVk9tdTFZGgk+4JlnGE1LwyzA44PPsoh+srq9XVmMLg==", null, false, "89918973-1a6b-469a-a0ef-8f82287e2213", false, "Carlos.Torres123@mail.com" },
                    { "4eff0a12-ba26-46c5-a652-10e8f900c85e", 0, "Trinidad Ocampos", "bdf7e2e7-6b06-4afc-87af-1c47a22a477f", null, "Abel.Trinidad123@mail.com", false, new DateOnly(2019, 7, 15), false, null, new DateOnly(2000, 1, 1), "Demetrio Abel", "ABEL.TRINIDAD123@MAIL.COM", null, "AQAAAAEAACcQAAAAEP0+1yZA4AlFfErqalBg+pfuwVmBxuc9aFUQj1q2Pa2ldeTFa1urkjBE2aVTKXxiSA==", null, false, "adcce46a-a8b5-4b88-aa94-caf30fa616df", false, null },
                    { "de236878-7a1f-473a-bdfe-30eab53efb6e", 0, "Kikuchi Yamamoto", "10392e53-635b-48ee-a0ff-f372b46bd0c1", null, "Erik.Kikuchi123@mail.com", false, new DateOnly(2018, 7, 13), false, null, new DateOnly(1999, 1, 1), "Erik Kaito", "ERIK.KIKUCHI123@MAIL.COM", null, "AQAAAAEAACcQAAAAEKE0/AG6E/Tep0zTaHhN4t0u/mlq9NBEcRrk3xlWTYohTuiH5wQxburdpwRcJDO+pA==", null, false, "1c8beb48-3503-4742-ae3e-6e02ca8d212f", false, null }
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
    }
}
