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
    public class showmethecodeController : ControllerBase
    {
        public string Get()
        {

            string link_url = "git@github.com:i7system/empregos.git";

            return link_url;
        }

    }
}