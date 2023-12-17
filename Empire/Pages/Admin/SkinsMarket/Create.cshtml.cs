using Empire.Data;
using Empire.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Empire.Pages.Admin.SkinsMarket
{
    public class CreateModel : PageModel
    {
        // Implementerer en OnPost handler, s� opslaget kan blive postet i hjemmesiden + i databasen
        // Bruger ogs� dependency injection for at f� det p� databasen ogs�

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
             _db.Skin.Add(skin);
            // Saving the changes from website to the database
            await _db.SaveChangesAsync();
            // Bruger TempData til at vise en besked og give brugeren besked p� at skin'et er blevet oprettet.
            TempData["success"] = "Skinopslaget er nu blevet oprettet";
            // Return til SkinMarket siden efter skin opslaget er oprettet
            return RedirectToPage("Index");

        }
    }
}
