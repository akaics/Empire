using Empire.Data;
using Empire.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Empire.Pages.Admin.SkinsMarket
{
    public class EditModel : PageModel
    {
        // Implementerer en OnPost handler, s� opslaget kan blive postet i hjemmesiden + i databasen
        // Bruger ogs� dependency injection for at f� det p� databasen ogs�

        private readonly ApplicationDbContext _db;
        public Skin Skin { get; set; }


        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet(int id)
        {
            Skin = _db.Skin.Find(id);
        }

        
        public async Task<IActionResult> OnPost(Skin skin)
        {
            if (ModelState.IsValid)
            {
                _db.Skin.Update(skin);

                await _db.SaveChangesAsync();
                //Fort�ller brugeren at opslaget er blevet �ndret
                TempData["success"] = "Skinopslaget er nu blevet �ndret";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
