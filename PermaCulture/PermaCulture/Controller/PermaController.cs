using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PermaCulture.Api.Controller;
using PermaCulture.Context;
using PermaCulture.Shared.Requests;

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

        [HttpDelete]
        [Route("{categoryId}")]
        //[Authorize(Constants.AdminRole)]
        //[ProducesResponseType(typeof(SuccessResponse), 200)]
        //[ProducesResponseType(typeof(SuccessResponse), 400)]
        public async Task<IActionResult> DeleteCategory(int categoryId)
        {
           // var userId = User.GetUserId();

            var response = await _categoryContext.DeleteCategoryAsync(categoryId);

            return GetActionResult(response);
        }
        [Route("api/create")]
        /// <summary>
        /// Create an Artist
        /// </summary>
        /// <remarks>Requires administrator privileges</remarks>
        [HttpPost]
        //[Authorize(Constants.AdminRole)]
        //[Consumes("application/json")]
        //[ProducesResponseType(typeof(ApiResponse<ArtistDto>), 200)]
        //[ProducesResponseType(typeof(SuccessResponse), 400)]

        public async Task<IActionResult> CreateCategory([FromBody]CategoryRequest request)
        {
            //var userId = User.GetUserId();

            var response = await _categoryContext.CreateArtistAsync(request, 0);

            return GetActionResult(response);
        }
    }
}