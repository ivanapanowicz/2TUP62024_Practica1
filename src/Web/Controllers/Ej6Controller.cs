using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(decimal precio, int cantidad, string formaPago, string numTarjeta = "")
        {
            if (precio < 0)
            {
                return BadRequest("El precio debe ser positivo.");
            }

            if (cantidad <= 0)
            {
                return BadRequest("La cantidad debe ser positiva.");
            }

            decimal total = precio * cantidad;

            formaPago = formaPago.ToLower().Trim();

            if (formaPago == "tarjeta")
            {
                if (string.IsNullOrWhiteSpace(numTarjeta) || numTarjeta.Length != 16)
                {
                    return BadRequest("El numero de la tarjeta debe tener 16 digitos.");
                }
                total += total * 0.1m;
            }
            else if (formaPago == "efectivo")
            {

            }
            else
            {
                return BadRequest("Debes seleccionar pagar con efectivo o tarjeta.");
            }

            return Ok($"El total a pagar es {total:C}");
        }
    }
}
