using Empire.Data;
using Empire.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Metadata.Ecma335;

/* Credits:
 * Kodet af Nuriye og G�ls�m Erdogan
 */
namespace Empire.Pages.Admin.SkinsMarket
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

        // Delete metode:
        public async Task<IActionResult> OnPost(Skin skin)
        {

            _db.Skin.Remove(skin);
            await _db.SaveChangesAsync();

            TempData["success"] = "Skinopslaget er nu blevet slettet";
            return RedirectToPage("Index");

        }
    }
}

