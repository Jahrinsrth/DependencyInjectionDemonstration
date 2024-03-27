namespace DependencyInjectionDemo.Services
{
    public class ScopedService : IScopedService
    {
        private readonly string GuidId;
        public ScopedService()
        {
            GuidId = Guid.NewGuid().ToString();
        }

        public string GetGuid()
        {
            return GuidId;
        }
    }
}
