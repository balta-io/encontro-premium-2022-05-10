using EncontroPremium.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EncontroPremium.Web.Pages;

public class IndexModel : PageModel
{
    [BindProperty(SupportsGet = true)] public short Len { get; set; } = 24;
    [BindProperty(SupportsGet = true)] public bool? SpecialChars { get; set; } = true;
    [BindProperty(SupportsGet = true)] public bool? UpperCase { get; set; } = false;
    public string Password { get; set; } = string.Empty;

    public void OnGet()
    {
        Password = PasswordGenerator.Generate(Len, SpecialChars ?? true, UpperCase ?? false);
    }
}