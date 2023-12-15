using Empire.Data;
using Empire.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Empire.Pages
{
    public class DeleteModel : PageModel
    {
       
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

        // Delete method
        public async Task<IActionResult> OnPost(Skin skin)
        {
            if (ModelState.IsValid)
            {
                
                var skinFromDb = _db.Skin.Find(Skin.Id);
                if (skinFromDb == null)
                {
                    _db.Skin.Remove(skinFromDb);
                    await _db.SaveChangesAsync();

                }
            }
            return RedirectToPage("Index");
        }
    }
}

