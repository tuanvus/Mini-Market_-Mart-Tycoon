using System.Collections.Generic;
using UnityEngine;

namespace UCExtension.UI
{
	public class ListItem<T, S> : MonoBehaviour where T : Item<S>
	{
		[SerializeField]
		private T prefab;

		[SerializeField]
		private Transform itemParent;

		private List<T> usingItems;

		private List<T> unuseItems;

		public List<T> UsingItems => null;

		public void Display(List<S> datas)
		{
		}

		protected virtual void OnItemSpawned(T item)
		{
		}

		public void AddUseItem(T item)
		{
		}

		public void AddUnuseItem(T item)
		{
		}
	}
}
