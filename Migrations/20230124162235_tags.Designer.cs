﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using elforo_be.Models;

#nullable disable

namespace elforo_be.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230124162235_tags")]
    partial class tags
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("elforo_be.Models.ent.Beca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("text");

                    b.Property<string>("NombreBeca")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Becas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "Beca disponibles para alumnos con promedio igual o mayor a 3.5",
                            NombreBeca = "Beca de la UNI"
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "Beca de movilidad a Kansas para alumnos del ultimo semestre",
                            NombreBeca = "Beca de movilidad"
                        },
                        new
                        {
                            Id = 3,
                            Descripcion = "Monto de 2500000, para alumnos de la promo 2022 y 2023",
                            NombreBeca = "Beca de Itaipu"
                        });
                });

            modelBuilder.Entity("elforo_be.Models.ent.Comentario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<int?>("QuestionId")
                        .HasColumnType("integer");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("UserId");

                    b.ToTable("Comentarios");
                });

            modelBuilder.Entity("elforo_be.Models.ent.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Anonymous")
                        .HasColumnType("boolean");

                    b.Property<string>("Ask")
                        .HasColumnType("text");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<string>("PersonId")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("elforo_be.Models.ent.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PF")
                        .HasColumnType("integer");

                    b.Property<int>("PP")
                        .HasColumnType("integer");

                    b.Property<int>("Score")
                        .HasColumnType("integer");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<DateOnly>("Year")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Interaccion Hombre Maquina",
                            PF = 59,
                            PP = 71,
                            Score = 1,
                            Year = new DateOnly(2022, 12, 21)
                        },
                        new
                        {
                            Id = 2,
                            Name = "Analisis Matematico III",
                            PF = 91,
                            PP = 80,
                            Score = 5,
                            Year = new DateOnly(2022, 12, 21)
                        },
                        new
                        {
                            Id = 3,
                            Name = "Fisica III",
                            PF = 82,
                            PP = 95,
                            Score = 4,
                            Year = new DateOnly(2022, 12, 23)
                        },
                        new
                        {
                            Id = 4,
                            Name = "Diseño Digital",
                            PF = 73,
                            PP = 81,
                            Score = 3,
                            Year = new DateOnly(2023, 1, 10)
                        });
                });

            modelBuilder.Entity("elforo_be.Models.ent.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("QuestionId")
                        .HasColumnType("integer");

                    b.Property<string>("TagName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("elforo_be.Models.ent.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("Apellido")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Doc")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<DateOnly>("Ingreso")
                        .HasColumnType("date");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateOnly>("Nacimiento")
                        .HasColumnType("date");

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "b5719520-8b53-48c7-9b13-98bbc79ef9b2",
                            AccessFailedCount = 0,
                            Apellido = "Torres",
                            ConcurrencyStamp = "d3f0b077-dfd4-4f09-b6f9-6e14dff2f3c8",
                            Email = "Carlos.Torres123@mail.com",
                            EmailConfirmed = false,
                            Ingreso = new DateOnly(2018, 7, 13),
                            LockoutEnabled = false,
                            Nacimiento = new DateOnly(1999, 7, 10),
                            Nombre = "Carlos",
                            NormalizedEmail = "CARLOS.TORRES@123MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEDaYNUfedloqxfoiOsXuzJ9PEO+wZqlGKAl5PCujdW9NfEu68kihBm4cnShM4w92NA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "19172422-f628-428e-a946-547f07bbe6e7",
                            TwoFactorEnabled = false,
                            UserName = "Carlos.Torres123@mail.com"
                        },
                        new
                        {
                            Id = "3cfb9e51-a50e-41f4-b43c-b50a61095e7c",
                            AccessFailedCount = 0,
                            Apellido = "Trinidad Ocampos",
                            ConcurrencyStamp = "c086ac03-52aa-4f23-85b1-7b99797de23e",
                            Email = "Abel.Trinidad123@mail.com",
                            EmailConfirmed = false,
                            Ingreso = new DateOnly(2019, 7, 15),
                            LockoutEnabled = false,
                            Nacimiento = new DateOnly(2000, 1, 1),
                            Nombre = "Demetrio Abel",
                            NormalizedEmail = "ABEL.TRINIDAD123@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEC+jYn+hQuekRQ0fO7m5CKkMnhjw/Y2k8MHAGJU4TvjdfdxIl27Jhx5TNRbBRNxZFg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "76e180a8-8b2f-4f7b-a27b-65443003f49a",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "8a57c250-bade-4c28-9704-a6b70306f321",
                            AccessFailedCount = 0,
                            Apellido = "Kikuchi Yamamoto",
                            ConcurrencyStamp = "e11674ad-b6b0-4b26-840d-726f109c14c3",
                            Email = "Erik.Kikuchi123@mail.com",
                            EmailConfirmed = false,
                            Ingreso = new DateOnly(2018, 7, 13),
                            LockoutEnabled = false,
                            Nacimiento = new DateOnly(1999, 1, 1),
                            Nombre = "Erik Kaito",
                            NormalizedEmail = "ERIK.KIKUCHI123@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEOmhxyNDOBt3cpMKjQl8tYIBqZ+YVKW1psp/E8Ks0TSH4pwijTMr3/wAXvtROqbU5Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "de93c605-11c5-4851-8055-1f293432adfa",
                            TwoFactorEnabled = false
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("elforo_be.Models.ent.Comentario", b =>
                {
                    b.HasOne("elforo_be.Models.ent.Question", "Question")
                        .WithMany("Comments")
                        .HasForeignKey("QuestionId");

                    b.HasOne("elforo_be.Models.ent.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Question");

                    b.Navigation("User");
                });

            modelBuilder.Entity("elforo_be.Models.ent.Question", b =>
                {
                    b.HasOne("elforo_be.Models.ent.User", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("elforo_be.Models.ent.Subject", b =>
                {
                    b.HasOne("elforo_be.Models.ent.User", "User")
                        .WithMany("Subjects")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("elforo_be.Models.ent.Tag", b =>
                {
                    b.HasOne("elforo_be.Models.ent.Question", "Question")
                        .WithMany("Tags")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("elforo_be.Models.ent.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("elforo_be.Models.ent.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("elforo_be.Models.ent.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("elforo_be.Models.ent.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("elforo_be.Models.ent.Question", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Tags");
                });

            modelBuilder.Entity("elforo_be.Models.ent.User", b =>
                {
                    b.Navigation("Subjects");
                });
#pragma warning restore 612, 618
        }
    }
}
