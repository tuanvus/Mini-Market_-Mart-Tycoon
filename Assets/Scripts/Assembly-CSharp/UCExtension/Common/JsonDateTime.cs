using System;

namespace UCExtension.Common
{
	[Serializable]
	internal struct JsonDateTime
	{
		public long value;

		public static implicit operator DateTime(JsonDateTime jdt)
		{
			return default(DateTime);
		}

		public static implicit operator JsonDateTime(DateTime dt)
		{
			return default(JsonDateTime);
		}
	}
}
