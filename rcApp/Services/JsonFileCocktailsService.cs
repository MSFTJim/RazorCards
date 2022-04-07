using System.Text.Json;
using rcApp.Models;

namespace rcApp.Services
{
    public class JsonFileCocktailsService
    {
        public JsonFileCocktailsService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "cocktailsdata.json"); }
        }

        public IEnumerable<Cocktail> GetCocktails()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Cocktail[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }

}
