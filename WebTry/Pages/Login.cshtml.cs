using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebTry.Data;
using WebTry.Model;

namespace WebTry.Pages;

[BindProperties]
public class LoginModel : PageModel
{
    private readonly SignInManager<IdentityUser> signInManager;
    private readonly ApplicationDbContext _db;

    public Login Model { get; set; }

    public LoginModel(ApplicationDbContext db)        
    {
        this.signInManager = signInManager;
        _db = db;
    }

    public void OnGet()
    {
        
    }

    public IActionResult OnPost(string email, string password)
    {
        if (email == null || password == null)
        {
            TempData["ErrorMessage"] = "Please fill in both email and password fields!";
            return Page();
        }

        var check = _db.User.FirstOrDefault(u => u.UserEmail == email && u.UserPassword == password);
        if (check != null)
        {
            TempData["SuccessfulLogin"] = true;
            HttpContext.Session.SetString("UserName", check.UserName); ;
            return RedirectToPage("Index", new {IsLoggedIn = true});
        }
        else
        {
            TempData["ErrorMessage"] = "Email or Password is Wrong!";
            return Page();
        }
    }


}


