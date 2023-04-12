using Microsoft.EntityFrameworkCore;

namespace FarmKurs.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Employeer> Employeers { get; set; }
        public DbSet<Laboratory> Laboratories { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<StaffHeadQuaters> StaffHeadQuaters { get; set; }
        public DbSet<TypeProduct> TypesProduct { get; set; }

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StaffHeadQuaters>()
                .HasMany(s => s.Employeers);

            modelBuilder.Entity<StaffHeadQuaters>()
                .HasOne(s => s.ManagerEmployeer);


        }
    }
}
