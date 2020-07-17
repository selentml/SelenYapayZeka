using Microsoft.EntityFrameworkCore;
using SelenYapayZekaGit.DAL.Classes;

namespace SelenYapayZekaGit.DAL
{
    public class SelenDB : DbContext
    {
        public DbSet<Kategori> Kategori { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                @"Server=tcp:selenyapayzekadb.database.windows.net,1433;Initial Catalog=selenDb;Persist Security Info=False;User ID=selenyapayzeka;Password=aSd415263.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}