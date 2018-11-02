using Songster.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PermaCulture.Shared
{
	public class ErrorResponse : AbstractResponse
	{
		public ErrorResponse()
		{
		}

		public ErrorResponse(StatusCode errorCode)
		{
			Error = new Error(errorCode);
		}

		public ErrorResponse(string errorMessage)
		{
			Error = new Error(errorMessage);
		}

		public ErrorResponse(Error error)
		{
			Error = error;
		}

		public ErrorResponse(Exception ex)
		{
			Error = new Error(StatusCode.UnhandledException, ex);
		}

		public ErrorResponse(StatusCode errorCode, Exception ex)
		{
			Error = new Error(errorCode, ex);
		}
	}
}
