using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string day)
        {
            string days = day.ToLower().Trim();

            List<string> weekdays = new List<string> { "lunes", "martes", "miércoles", "miercoles", "jueves", "viernes" };
            List<string> weekends = new List<string> { "sábado", "sabado", "domingo" };

            if (weekends.Contains(days))
            {
                return Ok("Es fin de semana");
            }
            else if (weekdays.Contains(days))
            {
                return Ok("No es fin de semana");
            }
            else
            {
                return BadRequest("Día no válido.");
            }
        }
    }
}
