using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace rcApp.Pages;

public class TimPiss : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public class Cocktail
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Desc { get; set; }
        public string? ImagePath { get; set; }

    };
    public List<Cocktail> Cocktails = new();

    public TimPiss(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }



    public void OnGet()
    {
        int dog = 0;
        
        Cocktails.Add(new Cocktail() { Id = 1001, Name = "Angel Envy", Price = 15.25M, ImagePath = "images/ae.jpg" , 
                                        Desc = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do 
                                            eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
                                            quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis 
                                            aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. 
                                            Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."});        
        Cocktails.Add(new Cocktail() { Id = 1002, Name = "Pappy Van winkle", Price = 15.25M, ImagePath = "images/pvw.jpg",
                                        Desc = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do 
                                            eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
                                            quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis 
                                            aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. 
                                            Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."});        
        Cocktails.Add(new Cocktail() { Id = 1003, Name = "Gas Flags", Price = 15.25M, ImagePath = "images/gasFlags.jpg",
                                        Desc = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do 
                                            eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
                                            quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis 
                                            aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. 
                                            Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."});        
        Cocktails.Add(new Cocktail() { Id = 1004, Name = "Remy Martin", Price = 15.25M, ImagePath = "images/reme.jpg" ,
                                        Desc = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do 
                                            eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
                                            quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis 
                                            aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. 
                                            Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."});        
        Cocktails.Add(new Cocktail() { Id = 1005, Name = "Coffee", Price = 15.25M, ImagePath = "images/coffee.jpg",
                                        Desc = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do 
                                            eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
                                            quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis 
                                            aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. 
                                            Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."});        
        Cocktails.Add(new Cocktail() { Id = 1006, Name = "Tanqueray", Price = 15.25M, ImagePath = "images/tanq.jpg",
                                        Desc = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do 
                                            eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
                                            quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis 
                                            aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. 
                                            Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."});        
        Cocktails.Add(new Cocktail() { Id = 1007, Name = "Beer", Price = 15.25M, ImagePath = "images/reme.jpg",
                                        Desc = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do 
                                            eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
                                            quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis 
                                            aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. 
                                            Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."});        
        
        // 


        dog++;




    }
}
