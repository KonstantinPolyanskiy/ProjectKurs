using Microsoft.EntityFrameworkCore;

namespace KotovKurs.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Journal> Journals { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<User>()
                .HasData
                (
                    new User()
                    {
                        Id = 1,
                        Surname = "Котов",
                        Name = "Илья",
                        LastName = "Игоревич",
                        Country = "Россия",
                        Email = "kotov.ilusha@mail.ru",
                        Login = "admin",
                        Password = "admin",
                        Phone = "89009329911"
                    }
                );
        }
    }
}
