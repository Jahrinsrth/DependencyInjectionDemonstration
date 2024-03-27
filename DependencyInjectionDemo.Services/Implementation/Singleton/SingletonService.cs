namespace DependencyInjectionDemo.Services
{
    public class SingletonService : ISingletonService
    {
        private readonly string GuidId;
        public SingletonService() 
        {
            GuidId = Guid.NewGuid().ToString();
        }

        public string GetGuid()
        {
            return GuidId;
        }
    }
}
