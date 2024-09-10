namespace Portafolio.Models
{
    public class HomeIndexDTO
    {
        public IEnumerable<ProjectDTO>? ProjectList { get; set; }

        public ExampleGuidModel exampleGuid { get; set; }

    }
}
