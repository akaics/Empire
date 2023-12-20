using Empire.Data;
using Empire.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
/* Credits:
 * Kodet af Nuriye og Gülsüm Erdogan
 */
namespace Empire.Pages.Admin.SkinsMarket
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
            Skin = new Skin();

        }

        public void OnGet()
        {
        }

        
        public async Task<IActionResult> OnPost(Skin skin)
        {
            //Add(Create) metoden: 
             _db.Skin.Add(skin);
            // Gemmer ændringerne fra hjemmesiden til databasen 
            await _db.SaveChangesAsync();
            // Bruger TempData til at vise en besked og give brugeren besked på at skin'et er blevet oprettet.
            TempData["success"] = "Skinopslaget er nu blevet oprettet";
            // Returnerer til SkinMarket siden efter skin opslaget er oprettet
            return RedirectToPage("Index");

        }
    }
}
