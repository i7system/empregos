using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class calculajurosController : ControllerBase
    {
        [HttpGet]
        public string calculajuros([FromQuery]double valorinicial, [FromQuery]double meses)
        {
            double Juros = 0;
            var taxajuros = new taxaJuros();
            Juros = taxajuros.retornarTaxaJurosAsync();

            double Valor_Final = (valorinicial * Math.Pow((1 + Juros), meses));
            string resultado = string.Format("{0:N}", Valor_Final);
            return resultado;
           
        }
    }
}