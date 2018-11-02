using Songster.Shared.Enums;
using System;
using System.Collections.Generic;

namespace PermaCulture.Shared
{
    public static class ErrorMessages
    {
        private static readonly Dictionary<StatusCode, string> _errors = new Dictionary<StatusCode, string>
        {
            [StatusCode.UnknownError]                 = null,
            [StatusCode.UnhandledException]           = "The service encountered an unhandled exception",
            [StatusCode.ConfigurationError]           = "Error in service configuration",
            [StatusCode.UserUnauthorized]             = "The user is not authorized to perform this operation",
            [StatusCode.UserNotFound]                 = "The requested user cannot be found",
            [StatusCode.AlbumNotFound]                = "The requested album cannot be found",
            [StatusCode.ArtistNotFound]               = "The requested artist cannot be found",
            [StatusCode.TrackQueueItemNotFound]       = "The requested queue item cannot be found",
            [StatusCode.PlaylistNotFound]             = "The requested playlist does not exist",
            [StatusCode.TrackNotFound]                = "The requested track does not exist",
            [StatusCode.EisRequestFailed]             = "A request to another service failed",
            [StatusCode.InvalidRequestParameterValue] = "Invalid parameter value was provided in the request",
            [StatusCode.GenreAttachedToAlbum]         = "The requested genre is related to at least one album",
            [StatusCode.GenreNotFound]                = "The requested genre not found",
        };

        public static string Get(StatusCode code) => _errors[code];
    }
}
