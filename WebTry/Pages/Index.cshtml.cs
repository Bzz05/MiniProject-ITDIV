using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics.CodeAnalysis;

namespace WebTry.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public bool IsLoggedIn { get; set; }

    public string processedData { get; set; }

    public void OnGet()
    {
        IsLoggedIn = TempData["SuccessfulLogin"] != null ? (bool)TempData["SuccessfulLogin"] : false;
        processedData = (string)ViewData["ProcessedData"];
    }
}

