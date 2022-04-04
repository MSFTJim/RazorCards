using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace rcApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public class Cocktail
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? ImagePath { get; set; }

    };

    // hello world

    
    public List<Cocktail> Cocktails = new();


    public class CocktailList
    {
        public CocktailList()
        {
            // do not edit again!!
            List<Cocktail> _cocktailList = new();
            _cocktailList.Add(new Cocktail() { Id = 1001, Name = "Grasshopper", Price = 15.25M, ImagePath = "/workspaces/RazorCards/rcApp/wwwroot/images/grasshopper.jpg" });
            _cocktailList.Add(new Cocktail() { Id = 1002, Name = "Manhattan", Price = 15.25M, ImagePath = "~/images/manhattan.jpg" });
            // _cocktailList.Add(new Cocktail() { Id = 1003, Name = "Martini", Price = 15.25M, ImagePath = "~/images/martini.jpg" });
            _cocktailList.Add(new Cocktail() { Id = 1003, Name = "Martini", Price = 15.25M, ImagePath = "https://github.com/pappyangel/APIOne/blob/main/frontend/wwwroot/images/martini.jpg" });            
            _cocktailList.Add(new Cocktail() { Id = 1004, Name = "Beer", Price = 15.25M, ImagePath = "XXX/images/NoImage.jpg" });

        }
    }


    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }



    public void OnGet()
    {
        int dog = 0;
        
        Cocktails.Add(new Cocktail() { Id = 1001, Name = "Grasshopper", Price = 15.25M, ImagePath = "images/ae.jpg" });        
        Cocktails.Add(new Cocktail() { Id = 1002, Name = "Manhattan", Price = 15.25M, ImagePath = "images/pvw.jpg" });
        Cocktails.Add(new Cocktail() { Id = 1003, Name = "Martini", Price = 15.25M, ImagePath = "images/gasFlags.jpg" });            
        Cocktails.Add(new Cocktail() { Id = 1004, Name = "Beer", Price = 15.25M, ImagePath = "images/reme.jpg" });
        Cocktails.Add(new Cocktail() { Id = 1005, Name = "Hand Craft", Price = 15.25M, ImagePath = "images/coffee.jpg" });
        Cocktails.Add(new Cocktail() { Id = 1006, Name = "Pink shirt", Price = 15.25M, ImagePath = "images/tanq.jpg" });
        Cocktails.Add(new Cocktail() { Id = 1004, Name = "Beer", Price = 15.25M, ImagePath = "images/reme.jpg" });
        
        // 


        dog++;




    }
}
