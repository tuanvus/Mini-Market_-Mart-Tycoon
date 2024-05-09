using UnityEngine;

namespace UCExtension.Common
{
	public class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		private static T instance;

		[SerializeField]
		private bool needDontDestroy;

		public static T Ins => null;

		protected virtual void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		protected virtual void SetUp()
		{
		}
	}
}
