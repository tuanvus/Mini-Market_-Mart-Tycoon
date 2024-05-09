using System;
using System.Collections.Generic;

namespace UCExtension.Randomize
{
	[Serializable]
	public class ListRandomItem<T, S> : RandomItem<T> where T : RandomItem<S>
	{
		public List<T> Items;

		public T GetRandomItem()
		{
			return null;
		}

		public ListRandomItem()
		{
			((RandomItem<>)(object)this)._002Ector();
		}
	}
}
