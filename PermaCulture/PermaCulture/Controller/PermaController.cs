using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PermaCulture.API.Controller
{

    public class PermaController : ControllerBase
    {
        [HttpGet]
        [Route("api/ping")]
        public ActionResult Ping()
        {

            return Ok("test");
        }
    }
}