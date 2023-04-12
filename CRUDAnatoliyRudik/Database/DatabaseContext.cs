using Microsoft.EntityFrameworkCore;

namespace AnatoliyRudik.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Operator> Operators { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Tariff> Tariffs { get; set; }
        public DbSet<TransportDelivery> TransportDeliveries { get; set; }

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tariff>()
                .HasData
                (
                    new Tariff() { Id = 1, Name = "Стандарт", Price = 100 },
                    new Tariff() { Id = 2, Name = "Экспресс", Price = 300 },
                    new Tariff() { Id = 3, Name = "Курьер", Price = 500 }
                );

            modelBuilder.Entity<TransportDelivery>()
                .HasData
                (
                    new TransportDelivery() { Id = 1, Name = "СДЕК", Address = "г. Воронеж, ул. Плехановская, д. 33" },
                    new TransportDelivery() { Id = 2, Name = "ВсеЛинии", Address = "г. Воронеж, ул. Генерала-Лизюкова, д. 91" },
                    new TransportDelivery() { Id = 3, Name = "Грузовичкофф", Address = "г. Воронеж, ул. Московский проспект, д. 47" }
                );
        }
    }
    }
