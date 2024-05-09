using UnityEngine;

namespace UCExtension.GUI
{
	public class BaseGUISingleton<T> : BaseGUI where T : BaseGUISingleton<T>
	{
		private static T instance;

		[SerializeField]
		private bool needDontDestroy;

		public static T Ins => null;

		protected new virtual void Awake()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
