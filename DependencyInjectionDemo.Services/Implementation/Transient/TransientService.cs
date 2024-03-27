namespace DependencyInjectionDemo.Services
{
    public class TransientService : ITransientService
    {
        private readonly string GuidId;
        public TransientService()
        {
            GuidId = Guid.NewGuid().ToString();
        }

        public string GetGuid()
        {
            return GuidId;
        }
    }
}
