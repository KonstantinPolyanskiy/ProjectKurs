using Microsoft.EntityFrameworkCore;

namespace ZnosokKurs.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Stop> Stops { get; set; }
        public DbSet<Transport> Transports { get; set; }
        public DbSet<TypeOfTransport> TypeOfTransports { get; set; }

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transport>()
                .HasOne(t => t.Type);

            modelBuilder.Entity<Route>()
                .HasMany(r => r.Stops)
                .WithMany(s => s.Routes);

            modelBuilder.Entity<User>()
                .HasData
                (
                    new User()
                    {
                        Id = 1,
                        Login = "Sergey",
                        Password = "Sergey",
                        Surname = "Зносок",
                        Name = "Сергей",
                        LastName = "Матвеев",
                        Phone = "+79009009911",
                        Position = "Разработчик"
                    }
                );
        }
    }
}
