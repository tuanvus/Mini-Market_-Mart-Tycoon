using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using pooling;

namespace dynamicscroll
{
	public abstract class DynamicScrollObject<T> : PoolingObject, IScrollItem, IComparable
	{
		protected Action refreshListAction;

		protected RectTransform rectTransform;

		public virtual float CurrentHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public virtual float CurrentWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public virtual int CurrentIndex
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsCentralized
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector2 PositionInViewport
		{
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector2 DistanceFromCenter
		{
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public RectTransform RectTransform => null;

		public virtual void Reset()
		{
		}

		public virtual void UpdateScrollObject(T item, int index)
		{
		}

		public virtual void SetRefreshListAction(Action action)
		{
		}

		public virtual void SetPositionInViewport(Vector2 position, Vector2 distanceFromCenter)
		{
		}

		public virtual void OnObjectIsCentralized()
		{
		}

		public virtual void OnObjectIsNotCentralized()
		{
		}

		public int CompareTo(object obj)
		{
			return 0;
		}
	}
}
