using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej10Controller : ControllerBase
    {

        [HttpGet]
        public IActionResult Get(int inicio, int final)
        {
            if (final - inicio >= 1000)
            {
                return BadRequest("La diferencia entre inicio y fin debe ser menor a 1000.");
            }

            List<int> par = new List<int>();
            List<int> impar = new List<int>();

            for (int i = inicio; i <= final; i++)
            {
                if (i % 2 == 0)
                {
                    par.Add(i);
                }
                else
                {
                    impar.Add(i);
                }
            }

            return Ok(new { Par = par, Impar = impar });
        }
    }
}