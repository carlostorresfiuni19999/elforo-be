using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using elforo_be.Models.ent;
using elforo_be.Helpers;

namespace elforo_be.Models
{
    public class ApplicationDbContext : IdentityDbContext<User> 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedData(modelBuilder);

        }

        private void SeedData(ModelBuilder builder)
        {
            SeedData seed = new SeedData(builder);
            seed.Seed();
        }

        public DbSet<Subject>? Subjects {get; set;}
        public DbSet<Question>? Questions {get; set;}
        public DbSet<Comentario>? Comentarios {get; set;}

    }
}