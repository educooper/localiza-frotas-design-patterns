using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Localiza.Frotas.Controller
{
    [Route("api/[controller]")]
    [ApiController]

    public class SingletonController : ControllerBase
    {

        [HttpGet()]

        public IActionResult Get()
        {
            //LINHA DO ERRO - NÃO ADD REFERENCIA AO SINGLETON EM infra
            var singleton = new Singleton();
            return Ok(singleton);
        }

    }
}

