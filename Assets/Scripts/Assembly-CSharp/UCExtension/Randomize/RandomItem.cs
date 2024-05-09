using System;

namespace UCExtension.Randomize
{
	[Serializable]
	public abstract class RandomItem<T>
	{
		public int Weight;

		public T Item;

		public virtual bool CanGet => false;
	}
}
