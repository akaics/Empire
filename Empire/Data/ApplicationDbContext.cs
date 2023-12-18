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

        public DbSet<Skin> Skin { get; set; }
        public DbSet<SkinType> SkinType { get; set; }

        public DbSet<SkinItem> SkinItem { get; set; }




    }
}
