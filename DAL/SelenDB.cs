using Microsoft.EntityFrameworkCore;
using SelenYapayZekaGit.DAL.Classes;

namespace SelenYapayZekaGit.DAL
{
    public class SelenDB : DbContext
    {
       
        public DbSet<Kategori> Kategori { get; set; }

        public DbSet<Urun> Urun { get; set; }

        public DbSet<Etiket> Etkiket { get; set; }



        public DbSet<UrunEtkiket> UrunEtiket { get; set; }
        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                @"Server=tcp:selenyapayzekadb.database.windows.net,1433;Initial Catalog=selenDb;Persist Security Info=False;User ID=selenyapayzeka;Password=aSd415263.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UrunEtkiket>().HasKey(et => new {et.EtkiketId, et.UrunId});
            modelBuilder.Entity<UrunEtkiket>().HasOne<Etiket>(et => et.Etiket).WithMany(ur => ur.UrunEtiket)
                .HasForeignKey(et => et.EtkiketId);

            modelBuilder.Entity<UrunEtkiket>().HasOne(ur => ur.Urun).WithMany(ur => ur.UrunEtiket)
                .HasForeignKey(ur => ur.UrunId);
        }
    }
}