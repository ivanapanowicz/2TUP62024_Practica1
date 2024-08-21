using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6LINQController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get([FromQuery] List<string> words)
        {
            var query = words.Select(w => w.Replace("ia", "*"));
            return query.ToList();
        }
    }
}
