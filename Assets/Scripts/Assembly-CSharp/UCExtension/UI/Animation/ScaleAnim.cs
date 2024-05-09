using DG.Tweening;
using UnityEngine;

namespace UCExtension.UI.Animation
{
	public class ScaleAnim : MonoBehaviour
	{
		[SerializeField]
		private bool autoPlay;

		[SerializeField]
		private Vector3 originalScale;

		[SerializeField]
		private Vector3 targetScale;

		[SerializeField]
		private float time;

		[SerializeField]
		private float time2;

		private Tween scaleTween;

		private bool isPlay;

		private void OnEnable()
		{
		}

		public void PlayAnim()
		{
		}

		public void StopAnim()
		{
		}
	}
}
