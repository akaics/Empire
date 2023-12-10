using Empire.Data;
using Empire.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Empire.Pages.SkinsMarket
{
    public class CreateModel : PageModel
    {
        // Implementerer en OnPost handler, så opslaget kan blive postet i hjemmesiden + i databasen
        // Bruger også dependency injection for at få det på databasen også

        private readonly ApplicationDbContext _db;
        public Skin Skin { get; set; }


        public CreateModel(ApplicationDbContext db)
        {
            _db = db;

        }

        public void OnGet()
        {
        }

        
        public async Task<IActionResult> OnPost(Skin skin)
        {
            await _db.Skin.AddAsync(skin);
            // Saving the changes to the database
            await _db.SaveChangesAsync();
            // Return til SkinMarket siden efter skin opslaget er oprettet
            return RedirectToPage("Index");

        }
    }
}
