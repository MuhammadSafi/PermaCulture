using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PermaCulture.Api.Controller;
using PermaCulture.Context;


namespace PermaCulture.API.Controller
{

    public class PermaController : PermaCultureControllerBase
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
        public async Task<IActionResult> Ping()
        {
            var response = await _categoryContext.GetCategories();
            return GetActionResult(response);
        }
    }
}