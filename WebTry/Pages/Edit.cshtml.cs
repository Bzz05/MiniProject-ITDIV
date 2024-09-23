using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebTry.Data;
using WebTry.Model;

namespace WebTry.Pages;

[BindProperties]
public class EditModel : PageModel
{

    private readonly ApplicationDbContext _db;

    public Category Category { get; set; }

    public EditModel(ApplicationDbContext db)
    {
        _db = db;
    }


    public void OnGet(int id)
    {
        Category = _db.Category.Find(id);
    }

    public async Task<IActionResult> OnPost()
    {
        _db.Category.Update(Category);
        await _db.SaveChangesAsync();
        return RedirectToPage("Categories");
    }
}


