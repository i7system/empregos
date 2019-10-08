using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class taxaJurosController : ControllerBase
    {
        public double Get()
        {
            double taxa = 0.01;
            return taxa;
        }
    }
}