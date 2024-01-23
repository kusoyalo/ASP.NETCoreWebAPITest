using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreWebAPITest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KusoController : ControllerBase
    {
        [HttpPost(Name = "Kuso")]
        public IEnumerable<Kuso> GetKuso()
        {
            return Enumerable.Range(1, 5).Select(data => new Kuso()).ToArray();
        }
    }
}
