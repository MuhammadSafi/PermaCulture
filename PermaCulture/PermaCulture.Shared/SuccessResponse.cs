using Songster.Shared.Enums;
using System;

namespace PermaCulture.Shared
{
	public class SuccessResponse : AbstractResponse
	{
		public SuccessResponse()
		{
			Success = true;
			ResponseStatusCode = StatusCode.Success;
		}

		public SuccessResponse(StatusCode errorCode)
		{
			Error = new Error(errorCode);
		}

		public SuccessResponse(string errorMessage)
		{
			Error = new Error(errorMessage);
		}

		public SuccessResponse(Error error)
		{
			Error = error;
		}

		public SuccessResponse(Exception ex)
		{
			Error = new Error(StatusCode.UnhandledException, ex);
		}

		public SuccessResponse(StatusCode errorCode, Exception ex)
		{
			Error = new Error(errorCode, ex);
		}
	}
}
