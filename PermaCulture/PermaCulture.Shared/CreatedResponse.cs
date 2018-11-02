﻿using PermaCulture.Shared;
using Songster.Shared.Enums;

namespace Songster.Shared
{
	public class CreatedResponse : AbstractResponse
	{
		public CreatedResponse(long newEntityId)
		{
			EntityId = newEntityId;
			Success = true;
			ResponseStatusCode = StatusCode.Created;
		}

		public long EntityId { get; set; }
	}
}
