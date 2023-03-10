using elforo_be.Models.ent;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace elforo_be.Helpers
{
    public class SeedData
    {
         private ModelBuilder builder;

        public SeedData(ModelBuilder builder)
        {
            this.builder = builder;
        }

        public void Seed()
        {
           var user = new User()
            {
                Email = "Carlos.Torres123@mail.com",
                NormalizedEmail = "CARLOS.TORRES@123MAIL.COM",
                Apellido = "Torres",
                UserName = "Carlos.Torres123@mail.com",
                Nombre = "Carlos",
                Nacimiento = new DateOnly(1999, 07, 10),
                Ingreso = new DateOnly(2018, 07, 13)

            };

            var hasher = new PasswordHasher<User>();
            user.PasswordHash = hasher.HashPassword(user, "Carlos.Torres123");

            var user2 = new User()
            {
                Email = "Abel.Trinidad123@mail.com",
                NormalizedEmail = "ABEL.TRINIDAD123@MAIL.COM",
                Apellido = "Trinidad Ocampos",
                Nombre = "Demetrio Abel",
                Nacimiento = new DateOnly(2000, 01, 01),
                Ingreso = new DateOnly(2019, 07, 15)
            };

            user2.PasswordHash = hasher.HashPassword(user2, "Abel.Trinidad123");

            var user3 = new User()
            {
                Email = "Erik.Kikuchi123@mail.com",
                NormalizedEmail = "ERIK.KIKUCHI123@MAIL.COM",
                Apellido = "Kikuchi Yamamoto",
                Nombre = "Erik Kaito",
                Nacimiento = new DateOnly(1999, 01, 01),
                Ingreso = new DateOnly(2018, 07, 13)
            };
            
            user3.PasswordHash = hasher.HashPassword(user3, "Erik.Kikuchi123");

           
            var ihm = new Subject()
            {
                Id = 1,
                Name = "Interaccion Hombre Maquina", 
                PP = 71, 
                PF = 59,
                Score = 1, 
                Year = new DateOnly(2022, 12, 21),
          
            };
            var a3 = new Subject()
            {
                Id = 2,
                Name = "Analisis Matematico III",
                PP = 80,
                PF = 91, 
                Score = 5,
                Year = new DateOnly(2022, 12, 21),
             
            };
            var f3 = new Subject()
            {
                Id = 3,
                Name = "Fisica III",
                PP = 95, 
                PF = 82,
                Score = 4,
                Year = new DateOnly(2022, 12, 23),
             
            };
            var dd = new Subject()
            {
                Id = 4,
                Name = "Dise??o Digital",
                PP = 81,
                PF = 73,
                Score = 3,
                Year = new DateOnly(2023, 01, 10),
              
            };

           
            var beca1 = new Beca()
            {
                Id = 1,
                NombreBeca = "Beca de la UNI",
                Descripcion = "Beca disponibles para alumnos con promedio igual o mayor a 3.5"
            };

            var beca2 = new Beca()
            {
                Id = 2, 
                NombreBeca = "Beca de movilidad",
                Descripcion = "Beca de movilidad a Kansas para alumnos del ultimo semestre"
            };

            var beca3 = new Beca()
            {
                Id = 3,
                NombreBeca = "Beca de Itaipu",
                Descripcion = "Monto de 2500000, para alumnos de la promo 2022 y 2023"
            };

            builder.Entity<User>()
            .HasData(user, user2, user3);

            builder.Entity<Beca>()
            .HasData(beca1, beca2, beca3);

            builder.Entity<Subject>()
            .HasData(ihm, a3, f3, dd);

            

        }
    }
}