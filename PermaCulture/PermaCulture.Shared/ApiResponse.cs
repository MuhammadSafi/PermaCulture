using Songster.Shared.Enums;
using System;

namespace PermaCulture.Shared
{
    public class ApiResponse<T> : SuccessResponse
	{
        public ApiResponse() : this(true)
        {

        }

		public ApiResponse(bool success = true)
		{
			Success = success;

			if (success)
			{
				ResponseStatusCode = StatusCode.Success;
			}
		}

		public ApiResponse(T result, int? limit = null, int? offset = null, int? total = null, bool success = true)
		{
			Value = result;
			Success = success;
			Limit = limit;
			Offset = offset;
			Total = total;

			if (success)
			{
				ResponseStatusCode = StatusCode.Success;
			}
		}

		public ApiResponse(StatusCode errorCode) : base(errorCode)
		{
		}

		public ApiResponse(string errorMessage) : base(errorMessage)
		{
		}

		public ApiResponse(Error error) : base(error)
		{
		}

		public ApiResponse(Exception ex) : base(ex)
		{
		}

		public ApiResponse(StatusCode errorCode, Exception ex) : base(errorCode, ex)
		{
		}

		public T Value { get; set; }

		public int? Limit { get; set; }

		public int? Offset { get; set; }

		public int? Total { get; set; }
	}
}
