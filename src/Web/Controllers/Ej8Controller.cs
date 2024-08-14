using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej8Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int inicio, int final)
        {
            if (final - inicio >= 1000)
            {
                return BadRequest("La diferencia entre inicio y fin debe ser menor a 1000.");
            }

            List<int> numbers = new List<int>();

            int i = inicio;

            while (i <= final) 
            {
                numbers.Add(i); 
                i++;
            }

            return Ok(numbers);
        }
    }
}
