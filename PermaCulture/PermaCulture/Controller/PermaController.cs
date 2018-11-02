using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PermaCulture.Context;


namespace PermaCulture.API.Controller
{

    public class PermaController : ControllerBase
    {

        private readonly ICategoryContext _categoryContext;

        public PermaController(ICategoryContext categoryContext)
        {
            _categoryContext = categoryContext;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/ping")]
        public async Task<ActionResult> Ping()
        {
            var aa = await _categoryContext.GetCategories();
            return Ok(aa);
        }
    }
}