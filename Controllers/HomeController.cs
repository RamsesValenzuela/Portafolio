using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Services;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProjectsRepository projectsRepository;

        public HomeController(ILogger<HomeController> logger, ProjectsRepository projectsRepository)
        {
            _logger = logger;
            this.projectsRepository = projectsRepository;
        }

        public IActionResult Index()
        {
            var person = new Person() {
                Name = "Ramses Valenzuela",
                age = 23

            };

            
            var projects = projectsRepository.getProjects().Take(2).ToList();

            var model = new HomeIndexDTO() { ProjectList = projects };

            return View(model);
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
