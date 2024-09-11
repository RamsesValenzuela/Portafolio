using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Services;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProjectsRepository projectsRepository;


        public HomeController(IProjectsRepository projectsRepository)
        {

            this.projectsRepository = projectsRepository;

        }

        public IActionResult Index()
        {

            var person = new Person() {
                Name = "Ramses Valenzuela",
                age = 23
            };

            var projects = projectsRepository.getProjects().Take(3).ToList();

            var model = new HomeIndexDTO() { 
                ProjectList = projects
            };

            return View(model);
        }


      
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Projects()
        {
            var projects = projectsRepository.getProjects();

            return View(projects);
        }

        public IActionResult Contact()
        {

            return View();
        }

        public IActionResult Thanks()
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
