using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace pooling
{
	public class Pooling<T> : List<T> where T : MonoBehaviour, IPooling
	{
		public delegate void ObjectCreationCallback(T obj);

		public bool createMoreIfNeeded;

		private Transform mParent;

		private Vector3 mStartPos;

		private GameObject referenceObject;

		public event ObjectCreationCallback OnObjectCreationCallBack
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public Pooling<T> Initialize(GameObject refObject, Transform parent)
		{
			return null;
		}

		public Pooling<T> Initialize(int amount, GameObject refObject, Transform parent, bool startState = false)
		{
			return null;
		}

		public Pooling<T> Initialize(int amount, GameObject refObject, Transform parent, Vector3 worldPos, bool startState = false)
		{
			return null;
		}

		public T Collect(Transform parent = null, Vector3? position = null, bool localPosition = true)
		{
			return null;
		}

		public void Release(T obj)
		{
		}

		public List<T> GetAllWithState(bool active)
		{
			return null;
		}

		private T CreateObject(Transform parent = null, Vector3? position = null)
		{
			return null;
		}

		public Pooling()
		{
			((List<T>)(object)this)._002Ector();
		}
	}
}
