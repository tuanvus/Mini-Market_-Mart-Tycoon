using System.Runtime.CompilerServices;
using UnityEngine;

namespace pooling
{
	public abstract class PoolingObject : MonoBehaviour, IPooling
	{
		public virtual string objectName => null;

		public bool isUsing
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public virtual void OnCollect()
		{
		}

		public virtual void OnRelease()
		{
		}
	}
}
