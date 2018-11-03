using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PermaCulture.Shared;

namespace PermaCulture.Api.Controller
{
    [ApiController]
    public class PermaCultureControllerBase : ControllerBase
    {

        protected ActionResult GetActionResult(AbstractResponse response, object routeVaules = null, string MethodName = "Get")
        {
            if (response.Success)
            {
                switch (response.ResponseStatusCode)
                {
                    case Shared.Enums.StatusCode.Created:
                        return CreatedAtAction(MethodName, routeVaules, response);
                    case Shared.Enums.StatusCode.Updated:
                    case Shared.Enums.StatusCode.Deleted:
                        return Ok(response);
                    default:
                        return Ok(response);
                }
            }
            else
            {
                switch (response.ResponseStatusCode)
                {
                    case Shared.Enums.StatusCode.UserUnauthorized:
                        return Forbid();
                    case Shared.Enums.StatusCode.PlaylistNotFound:
                    case Shared.Enums.StatusCode.AlbumNotFound:
                    case Shared.Enums.StatusCode.TrackNotFound:
                    case Shared.Enums.StatusCode.TrackQueueItemNotFound:
                    case Shared.Enums.StatusCode.ArtistNotFound:
                    case Shared.Enums.StatusCode.UserNotFound:
                        return NotFound(response);
                    default:
                        return BadRequest(response);
                }
            }
        }

        // TODO: implement or remove all actions using this method
        /// <summary>
        /// Use as a return value for actions that are not yet implemented
        /// </summary>
        /// <returns><see cref="EmptyResult"/></returns>
        protected async Task<ActionResult> GetDummyResponse()
        {
            return await Task.FromResult(new EmptyResult());
        }
    }
}