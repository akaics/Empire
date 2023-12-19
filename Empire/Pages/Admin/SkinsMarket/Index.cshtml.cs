using Empire.Data;
using Empire.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

/*Credits:  
 Kodet af Nuriye og Gülsüm Erdogan*/

namespace Empire.Pages.Admin.SkinsMarket
{
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        // property der holder listen af skins
        public IEnumerable<Skin> Skins { get; set; }

        // Bruger dependency injection til at implementere klassen

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        // Henter listen af skins 
        public void OnGet()
        {
            Skins = _db.Skin;
        }
    }
}
