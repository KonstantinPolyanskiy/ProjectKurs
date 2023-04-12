using Microsoft.EntityFrameworkCore;

namespace DanilSalikov.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Door> Doors { get; set; }

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Manufacturer>()
                .HasKey(m => m.Id);

            modelBuilder.Entity<Material>()
                .HasKey(m => m.Id);

            modelBuilder.Entity<Door>()
                .HasKey(d => d.Id);

            modelBuilder.Entity<Door>()
                .HasOne(d => d.Category);

            modelBuilder.Entity<Door>()
                .HasOne(d => d.Manufacturer);

            modelBuilder.Entity<Door>()
                .HasOne(d => d.Material);

            modelBuilder.Entity<Category>()
                .HasData
                (
                    new Category() { Id = 1, Name = "Межкомнатные" },
                    new Category() { Id = 2, Name = "Входные" }
                );

            modelBuilder.Entity<Manufacturer>()
                .HasData
                (
                    new Manufacturer() { Id = 1, Name = "Zetta", Address = "Город Воронеж, ул. 23" }
                );

            modelBuilder.Entity<Material>()
                .HasData
                (
                    new Material() { Id = 1, Name = "Дуб" },
                    new Material() { Id = 2, Name = "Сосна" }
                );
        }
    }
}
