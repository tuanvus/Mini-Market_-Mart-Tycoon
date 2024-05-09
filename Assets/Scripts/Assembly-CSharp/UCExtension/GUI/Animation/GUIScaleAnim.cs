using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

namespace UCExtension.GUI.Animation
{
	public class GUIScaleAnim : GUIAnim
	{
		[SerializeField]
		private Transform target;

		[SerializeField]
		private bool dontNeedCloseAnimation;

		[SerializeField]
		[Range(0f, 1f)]
		private float startScale;

		[SerializeField]
		private float timeScaleUp;

		[SerializeField]
		private float timeScaleDown;

		[SerializeField]
		private Ease scaleUpEase;

		[SerializeField]
		private Ease scaleDownEase;

		private Tween scaleTween;

		public override void Open(UnityAction finish = null)
		{
		}

		public override void Close(UnityAction finish = null)
		{
		}
	}
}
