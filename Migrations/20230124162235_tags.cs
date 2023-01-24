using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace elforo_be.Migrations
{
    public partial class tags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Questions");

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TagName = table.Column<string>(type: "text", nullable: true),
                    QuestionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tags_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Apellido", "ConcurrencyStamp", "Doc", "Email", "EmailConfirmed", "Ingreso", "LockoutEnabled", "LockoutEnd", "Nacimiento", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3cfb9e51-a50e-41f4-b43c-b50a61095e7c", 0, "Trinidad Ocampos", "c086ac03-52aa-4f23-85b1-7b99797de23e", null, "Abel.Trinidad123@mail.com", false, new DateOnly(2019, 7, 15), false, null, new DateOnly(2000, 1, 1), "Demetrio Abel", "ABEL.TRINIDAD123@MAIL.COM", null, "AQAAAAEAACcQAAAAEC+jYn+hQuekRQ0fO7m5CKkMnhjw/Y2k8MHAGJU4TvjdfdxIl27Jhx5TNRbBRNxZFg==", null, false, "76e180a8-8b2f-4f7b-a27b-65443003f49a", false, null },
                    { "8a57c250-bade-4c28-9704-a6b70306f321", 0, "Kikuchi Yamamoto", "e11674ad-b6b0-4b26-840d-726f109c14c3", null, "Erik.Kikuchi123@mail.com", false, new DateOnly(2018, 7, 13), false, null, new DateOnly(1999, 1, 1), "Erik Kaito", "ERIK.KIKUCHI123@MAIL.COM", null, "AQAAAAEAACcQAAAAEOmhxyNDOBt3cpMKjQl8tYIBqZ+YVKW1psp/E8Ks0TSH4pwijTMr3/wAXvtROqbU5Q==", null, false, "de93c605-11c5-4851-8055-1f293432adfa", false, null },
                    { "b5719520-8b53-48c7-9b13-98bbc79ef9b2", 0, "Torres", "d3f0b077-dfd4-4f09-b6f9-6e14dff2f3c8", null, "Carlos.Torres123@mail.com", false, new DateOnly(2018, 7, 13), false, null, new DateOnly(1999, 7, 10), "Carlos", "CARLOS.TORRES@123MAIL.COM", null, "AQAAAAEAACcQAAAAEDaYNUfedloqxfoiOsXuzJ9PEO+wZqlGKAl5PCujdW9NfEu68kihBm4cnShM4w92NA==", null, false, "19172422-f628-428e-a946-547f07bbe6e7", false, "Carlos.Torres123@mail.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tags_QuestionId",
                table: "Tags",
                column: "QuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tags");

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

            migrationBuilder.AddColumn<List<string>>(
                name: "Tags",
                table: "Questions",
                type: "text[]",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Apellido", "ConcurrencyStamp", "Doc", "Email", "EmailConfirmed", "Ingreso", "LockoutEnabled", "LockoutEnd", "Nacimiento", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "340c1934-8b05-40a6-9427-bc03b738c158", 0, "Kikuchi Yamamoto", "a1714ea1-9a2d-4e70-812d-68d28faf0e8b", null, "Erik.Kikuchi123@mail.com", false, new DateOnly(2018, 7, 13), false, null, new DateOnly(1999, 1, 1), "Erik Kaito", "ERIK.KIKUCHI123@MAIL.COM", null, "AQAAAAEAACcQAAAAEAeWS7MRFcWKZQuJPn4zrLfzFURxT4NV9wsLsAkhkGrbHa4HJE+66xcHI0WEHoURrg==", null, false, "2a08fcad-6805-45c4-bc67-a06c09882f90", false, null },
                    { "475d5835-d31c-403b-8d73-046b0e082969", 0, "Torres", "4b27bf08-6ad4-4a4e-a6fb-dca1c5a8aa68", null, "Carlos.Torres123@mail.com", false, new DateOnly(2018, 7, 13), false, null, new DateOnly(1999, 7, 10), "Carlos", "CARLOS.TORRES@123MAIL.COM", null, "AQAAAAEAACcQAAAAELqwwrGmPhKnJ0yWFhoOfwKO9uxV9BRyRaRWztgmAwj992eAuHwe7eYaZpw1ZismXw==", null, false, "9265feb0-aaf6-4242-ae79-27c78b8de984", false, "Carlos.Torres123@mail.com" },
                    { "e54cfda3-ac92-44a4-8bc1-a7c7f515a379", 0, "Trinidad Ocampos", "5f67ce03-d047-4623-b5a8-fdcc4c2c649b", null, "Abel.Trinidad123@mail.com", false, new DateOnly(2019, 7, 15), false, null, new DateOnly(2000, 1, 1), "Demetrio Abel", "ABEL.TRINIDAD123@MAIL.COM", null, "AQAAAAEAACcQAAAAEJ0bBGJdedOyQ+sNziN6tHSvcMjPmKUbajUtL1Xvm5KSh+O5iSc+0lX5Gx8MyusZAQ==", null, false, "cef1e90b-411b-476b-a482-2064abd72a4a", false, null }
                });
        }
    }
}
