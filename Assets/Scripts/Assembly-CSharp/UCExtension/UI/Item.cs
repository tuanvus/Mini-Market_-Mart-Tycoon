using System.Runtime.CompilerServices;
using UnityEngine;

namespace UCExtension.UI
{
	public abstract class Item<T> : MonoBehaviour
	{
		public T HoldingData
		{
			[CompilerGenerated]
			get
			{
				return default(T);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public virtual void SetData(T data)
		{
		}
	}
}
