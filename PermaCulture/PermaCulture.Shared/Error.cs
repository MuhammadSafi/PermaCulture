using Songster.Shared.Enums;
using System;
using System.Collections.Generic;

namespace PermaCulture.Shared
{
	/// <summary>
	/// Recommended error message format for REST APIs
	/// </summary>
	/// <remarks>
	/// Modelled after Microsoft REST API Guidelines
	/// https://github.com/Microsoft/api-guidelines/blob/vNext/Guidelines.md#710-response-formats
	/// </remarks>
	public class Error
    {
		#region Constructors

		/// <summary>
		/// Creates an <see cref="Error"/> instance
		/// </summary>
		/// <param name="errorCode">Error code</param>
		/// <param name="target">The target of the error (e.g. the name of the property or method in error)</param>
		public Error(StatusCode errorCode, string target = null)
		{
			Code = errorCode;
			Message = ErrorMessages.Get(errorCode);
			Target = target;
		}

		/// <summary>
		/// Creates an <see cref="Error"/> instance with a custom message
		/// </summary>
		/// <param name="message">Error message</param>
		public Error(string message)
		{
			Code = StatusCode.UnknownError;
			Message = message;
		}

		/// <summary>
		/// Creates an <see cref="Error"/> instance with exception messages in <see cref="Details"/>
		/// </summary>
		/// <remarks>Exception details shown only if the solution is built in debug configuration</remarks>
		/// <param name="errorCode">Error code</param>
		/// <param name="ex">Exception instrance</param>
		/// <param name="target">The target of the error (e.g. the name of the property or method in error)</param>
		public Error(StatusCode errorCode, Exception ex, string target = null) : this(errorCode, target)
		{
#if DEBUG
			Details = new List<Error>();

			while (ex != null)
			{
				Details.Add(new Error(ex));
				ex = ex.InnerException;
			}
#endif
		}

		private Error(Exception ex)
		{
			Code = StatusCode.UnhandledException;
			Message = ex.Message;
		}

		#endregion


		/// <summary>
		/// One of the server-defined set of error codes.
		/// </summary>
        public StatusCode Code { get; set; }

		/// <summary>
		/// A human-readable representation of the error.
		/// </summary>
	    public string Message { get; set; }

		/// <summary>
		/// The target of the error (e.g. the name of the property or method in error).
		/// </summary>
	    public string Target { get; set; }

		/// <summary>
		/// An array of details about specific errors that led to this reported error.
		/// </summary>
	    public List<Error> Details { get; set; }
    }
}
