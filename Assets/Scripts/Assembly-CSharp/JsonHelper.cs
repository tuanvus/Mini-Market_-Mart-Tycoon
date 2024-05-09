using System;

public class JsonHelper
{
	[Serializable]
	private class Wrapper<T>
	{
		public T[] array;
	}

	public static T[] getJsonArray<T>(string json)
	{
		return null;
	}
}
