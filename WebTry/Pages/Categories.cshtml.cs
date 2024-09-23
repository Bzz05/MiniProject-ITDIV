using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebTry.Data;
using WebTry.Model;

namespace WebTry.Pages;


[BindProperties]
public class CategoriesModel : PageModel
{
    private readonly ApplicationDbContext _db;

    public IEnumerable<Category> Categories { get; set; }

    public Category Category { get; set; }


    public CategoriesModel(ApplicationDbContext db)
    {
        _db = db;
    }

    public void OnGet()
    {
        Categories = _db.Category;        
    }

    public async Task<IActionResult> OnPost()
    {
        await _db.Category.AddAsync(Category);
        await _db.SaveChangesAsync();
        return RedirectToPage("Categories");
    }
}

