using Empire.Model;
using Microsoft.EntityFrameworkCore;

namespace Empire.Data
{
    public class ApplicationDbContext : DbContext
    {
        //Denne klasse, ApplicationDbContext vil gøre det muligt for os at interagere med databasen. 
        //Vi laver en tom constructor, elles vil connection ikke virke: 

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
            


        //Opretter tables - det er de 3 tabeller her, som vil oprettes i SQL databasen:

        public DbSet<Skin> Skin { get; set; }
        public DbSet<SkinType> SkinType { get; set; }

        public DbSet<SkinItem> SkinItem { get; set; }




    }
}
