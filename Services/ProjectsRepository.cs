using Portafolio.Models;

namespace Portafolio.Services
{

    public interface IProjectsRepository
    {
        List<ProjectDTO> getProjects();
    }

    public class ProjectsRepository: IProjectsRepository
    {
        public List<ProjectDTO> getProjects()
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

    }
}
