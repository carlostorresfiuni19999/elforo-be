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

            var user3 = new User()
            {
                Email = "Erik.Kikuchi123@mail.com",
                NormalizedEmail = "ERIK.KIKUCHI123@MAIL.COM",
                Apellido = "Kikuchi Yamamoto",
                Nombre = "Erik Kaito",
                Nacimiento = new DateOnly(1999, 01, 01),
                Ingreso = new DateOnly(2018, 07, 13)
            };
            

            builder.Entity<User>()
                .HasData(
                    user, user2, user3
                );

                
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
                Name = "Diseño Digital",
                PP = 81,
                PF = 73,
                Score = 3,
                Year = new DateOnly(2023, 01, 10),
              
            };

            builder.Entity<Subject>()
                .HasData(
                    a3, f3, dd, ihm
                );
        
            

        }
    }
}