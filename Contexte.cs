using Microsoft.EntityFrameworkCore;
using Exercice2_ClubVideo.Models;
namespace Exercice2_ClubVideo
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=PETU-STI-35\\SQLEXPRESS;Initial Catalog=Exercice2_ClubVideo;Integrated Security=True;TrustServerCertificate=Yes");
        }

        public DbSet<Clients> clients { get; set; }
        public DbSet<Facture> facture { get; set; }
        public DbSet<Films> films { get; set; }
    }
}
