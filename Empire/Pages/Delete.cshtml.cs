using Empire.Data;
using Empire.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Empire.Pages
{
    public class DeleteModel : PageModel
    {
        // Implementerer en OnPost handler, s� opslaget kan blive postet i hjemmesiden + i databasen
        // Bruger ogs� dependency injection for at f� det p� databasen ogs�

        private readonly ApplicationDbContext _db;
        public Skin Skin { get; set; }


        public DeleteModel(ApplicationDbContext db)
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
                var skinFromDb = _db.Skin.Find(Skin.Id);
                await _db.SaveChangesAsync();
            }
            return RedirectToPage("Index");
        }
    }
}
