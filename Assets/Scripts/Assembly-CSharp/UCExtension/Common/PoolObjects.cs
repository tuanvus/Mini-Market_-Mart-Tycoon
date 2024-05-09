using System.Collections.Generic;
using UnityEngine;

namespace UCExtension.Common
{
	public class PoolObjects : Singleton<PoolObjects>
	{
		[SerializeField]
		private Dictionary<string, RecylableObject> prefabPool;

		[SerializeField]
		private Dictionary<string, Queue<RecylableObject>> instantiatedObjects;

		private bool HasPrefabInPool(string name)
		{
			return false;
		}

		private void AddToPool(RecylableObject newObject)
		{
		}

		public RecylableObject SpawnObject(RecylableObject prefab, Transform parent = null)
		{
			return null;
		}

		public RecylableObject SpawnObject(RecylableObject prefab, Vector3 position)
		{
			return null;
		}

		public RecylableObject SpawnObject(RecylableObject prefab, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		public T SpawnObject<T>(RecylableObject prefab, Transform parent = null)
		{
			return default(T);
		}

		public T SpawnObject<T>(RecylableObject prefab, Vector3 position, Transform parent = null)
		{
			return default(T);
		}

		private RecylableObject GetNewObject(string prefabName)
		{
			return null;
		}

		public void DestroyObject(RecylableObject obj)
		{
		}

		private RecylableObject GetPrefab(string prefabName)
		{
			return null;
		}

		public PoolObjects()
		{
			((Singleton<>)(object)this)._002Ector();
		}
	}
}
