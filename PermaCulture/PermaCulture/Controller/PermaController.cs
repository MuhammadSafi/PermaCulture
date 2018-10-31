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

        private readonly CategoryContext _categoryContext;

        public PermaController(CategoryContext categoryContext)
        {
            _categoryContext = categoryContext;
           
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/ping")]
        public ActionResult Ping()
        {
            //PermaCultureContext aa = new PermaCultureContext();
            //var lst = aa.Category.Select(a => a.Content).ToList();
            //return Ok(lst);
            var aa=_categoryContext.GetCategories();
            return Ok("da");
        }
    }
}