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
                Title = "Consejo Regulador del Bacanora",
                Description = "Hybrid web application developed with a focus on facilitating the control of bacanora producers.",
                Link = "https://consejo-regulador-db.web.app/login",
                ImageUrl = "/images/Bacanora_app.png"
            },
               new ProjectDTO
            {
                Title = "Crossing Road",
                Description = "VR video game developed using c# and unity to teach the right way to cross the street",
                Link = "",
                ImageUrl = "/images/Crossing_Road.png"
            },
               new ProjectDTO
            {
                Title = "Bienes Raices",
                Description = "Web application developed with node.js and express.js to register houses for sale or rent.",
                Link = "",
                ImageUrl = "/images/Bienes_Raices.png"
            },


            };

        }

    }
}
