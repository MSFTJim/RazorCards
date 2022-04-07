using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using  rcApp.Models;
using rcApp.Services;

namespace rcApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;   
    public JsonFileCocktailsService _cocktailService;
    
    public IEnumerable<Cocktail> Cocktails {get; private set;}

    public IndexModel(ILogger<IndexModel> logger,
                        JsonFileCocktailsService cocktailService)
    {
        _logger = logger;
        _cocktailService = cocktailService;

    }



    public void OnGet()
    {
        int dog = 0;

        Cocktails = _cocktailService.GetCocktails();

        dog++;

    }
}
