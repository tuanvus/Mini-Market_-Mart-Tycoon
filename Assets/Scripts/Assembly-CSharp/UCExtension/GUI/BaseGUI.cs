using UCExtension.GUI.Animation;
using UnityEngine;
using UnityEngine.Events;

namespace UCExtension.GUI
{
	public abstract class BaseGUI : MonoBehaviour
	{
		[SerializeField]
		private AudioClip openSound;

		private GUIAnim anim;

		protected bool isAnimating;

		private Canvas mainCanvas;

		private bool isOpenning;

		public Canvas MainCanvas => null;

		public virtual void Close(UnityAction finish = null)
		{
		}

		public virtual void Open(object[] initParams, UnityAction finish = null)
		{
		}

		protected virtual void Awake()
		{
		}

		protected virtual void SetUp()
		{
		}
	}
}
