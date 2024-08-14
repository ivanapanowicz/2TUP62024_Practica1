using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej9Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int inicio, int final)
        {
            if (final - inicio >= 1000)
            {
                return BadRequest("La diferencia entre inicio y fin debe ser menor a 1000.");
            }

            List<int> numbers = new List<int>();

            for (int i = inicio; i <= final; i++)
            {
                if (i % 2 == 0)
                {
                    numbers.Add(i);
                }
            }

            return Ok(numbers);
        }
    }
}
