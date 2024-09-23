using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebTry.Data;
using WebTry.Model;

namespace WebTry.Pages;

[BindProperties]
public class DeleteModel : PageModel
{

    private readonly ApplicationDbContext _db;

    public Category Category { get; set; }

    public DeleteModel(ApplicationDbContext db)
    {
        _db = db;
    }

    public void OnGet(int id)
    {
        Category = _db.Category.Find(id);
    }

    public async Task<IActionResult> OnPost()
    {
        var categoryFromDb = _db.Category.Find(Category.CategoryID);
            _db.Category.Remove(categoryFromDb);
            await _db.SaveChangesAsync();
        return RedirectToPage("Categories");
    }
}


