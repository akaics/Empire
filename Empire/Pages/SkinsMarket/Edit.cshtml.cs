using Empire.Data;
using Empire.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Empire.Pages.SkinsMarket
{
    public class EditModel : PageModel
    {
        // Implementerer en OnPost handler, så opslaget kan blive postet i hjemmesiden + i databasen
        // Bruger også dependency injection for at få det på databasen også

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

        
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                _db.Skin.Update(Skin);

                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
