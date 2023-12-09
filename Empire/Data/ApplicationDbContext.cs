using Empire.Model;
using Microsoft.EntityFrameworkCore;

namespace Empire.Data
{
    public class ApplicationDbContext : DbContext
    {
        //Vi laver en tom constructor, elles vil connection ikke virke: 

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
            


        //Opretter tables:
        public DbSet<Bruger> Bruger { get; set; }

        public DbSet<Skin> Skin { get; set; }
        public DbSet<Søgekriterier> Søgekriterier { get; set; }

        public DbSet<Salgsopslag> SalgsOpslag { get; set; }




    }
}
