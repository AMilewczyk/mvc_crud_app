using System.Diagnostics;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using mvc_crud_app.Models;

namespace mvc_crud_app.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        var model = new List<Cat>()
        { 
            new Cat()
            {
                CatName = "felix",
                CatRace = "pers"
            },
            new Cat()
            {
                CatName = "Filo",
                CatRace = "bengalski"

            },

        };

        return View(model);
    }

    public IActionResult About()
    {
        var model = new About()
        {
            Title = "CatStore",
            Description = "CrudCat",
            Tags = new List<string>() { "simple", "crud", "app" }
        };

        return View(model);
    }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
