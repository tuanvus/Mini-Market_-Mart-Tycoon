using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

public class SpringAnimation : SingleAnimation
{
	[SerializeField]
	private float timeScaleUp;

	[SerializeField]
	private float timeScaleDown;

	[SerializeField]
	private Vector3 originalScale;

	[SerializeField]
	private Vector3 scaleUp;

	private Tween animTween;

	public override void Play(UnityAction finish = null)
	{
	}
}
