using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var person = new Person() {
                Name = "Ramses Valenzuela",
                age = 23

            };

            var projects = getProjects();

            var model = new HomeIndexDTO() { ProjectList = projects };

            return View(model);
        }


        private List<ProjectDTO> getProjects()
        {
            return new List<ProjectDTO>() { 
                new ProjectDTO
            {
                Title = "Amazon",
                Description = "E-Commerse system developed on ASP.NET Core",
                Link = "https://amazon.com",
                ImageUrl = "/images/amazon.png"
            },
               new ProjectDTO
            {
                Title = "New York Time",
                Description = "Newletter page on react",
                Link = "https://nytimes.com",
                ImageUrl = "/images/nyt.png"
            }
            };

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
