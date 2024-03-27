using DependencyInjectionDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ISingletonService _singletonService1;
        private readonly ISingletonService _singletonService2;

        private readonly IScopedService _scopedService1;
        private readonly IScopedService _scopedService2;

        private readonly ITransientService _transientService1;
        private readonly ITransientService _transientService2;

        public TestController(
            ISingletonService singletonService1, ISingletonService singletonService2, 
            IScopedService scopedService1, IScopedService scopedService2, 
            ITransientService transientService1, ITransientService transientService2)
        {
            // Singleton
            this._singletonService1 = singletonService1;
            this._singletonService2 = singletonService2;

            // Scoped
            this._scopedService1 = scopedService1;
            this._scopedService2 = scopedService2;

            // Transient
            this._transientService1 = transientService1;
            this._transientService2 = transientService2;
        }

        [HttpGet]
        [Route("singleton")]
        public IActionResult GetSingleton()
        {
            Response response = new()
            {
                ResultId_1 = _singletonService1.GetGuid(),
                ResultId_2 = _singletonService2.GetGuid()
            };

            return Ok(response);
        }

        [HttpGet]
        [Route("Transient")]
        public IActionResult GetTransient()
        {
            Response response = new()
            {
                ResultId_1 = _transientService1.GetGuid(),
                ResultId_2 = _transientService2.GetGuid()
            };

            return Ok(response);
        }

        [HttpGet]
        [Route("Scoped")]
        public IActionResult GetScoped()
        {
            Response response = new()
            {
                ResultId_1 = _scopedService1.GetGuid(),
                ResultId_2 = _scopedService2.GetGuid()
            };

            return Ok(response);
        }

    }
}
