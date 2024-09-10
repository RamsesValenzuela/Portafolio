namespace Portafolio.Services
{
    public class UniqueService
    {
        public UniqueService()
        {
            getGuid = Guid.NewGuid();
        }

        public Guid getGuid { get; private set; }

    }

    public class DelimitedService
    {
        public DelimitedService()
        {
            getGuid = Guid.NewGuid();
        }

        public Guid getGuid { get; private set; }

    }

    public class TransientService
    {
        public TransientService()
        {
            getGuid = Guid.NewGuid();
        }

        public Guid getGuid { get; private set; }

    }




}
