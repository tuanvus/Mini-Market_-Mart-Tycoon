using System;

namespace API.RemoteConfig
{
	[Serializable]
	public class RemoteConfigData
	{
		public string Key;

		public RemoteConfigDataType DataType;

		public string Data;
	}
}
