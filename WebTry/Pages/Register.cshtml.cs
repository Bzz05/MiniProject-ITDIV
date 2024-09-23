using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebTry.Data;
using WebTry.Model;

namespace WebTry.Pages;

public class RegisterModel : PageModel
{

    private readonly UserManager<IdentityUser> userManager;
    private readonly SignInManager<IdentityUser> signInManager;
    private readonly ApplicationDbContext _db;

    [BindProperty]
    public Register Model { get; set; }

    public RegisterModel(ApplicationDbContext db, UserManager<IdentityUser>userManager, SignInManager<IdentityUser>signInManager)
    {
        this.userManager = userManager;
        this.signInManager = signInManager;
        _db = db;
    }

    public void OnGet()
    {
    }


    public IActionResult OnPost(string username, string email,
            string password)
    {

        var userCek = _db.Users.Any(u => u.Email == email);
        if (userCek)
        {
            return BadRequest("Email already registered");
        }
        var newuser = new User
        {
            UserName = username,
            UserEmail = email,
            UserPassword = password,
            
        };
        _db.User.Add(newuser);
        _db.SaveChanges();

        return RedirectToPage("Login");
    }
}


