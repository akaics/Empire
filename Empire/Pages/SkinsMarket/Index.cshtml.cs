using Empire.Data;
using Empire.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Empire.Pages.SkinsMarket
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
