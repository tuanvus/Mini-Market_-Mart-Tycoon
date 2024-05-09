using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ProgressUI : TransformFollowerUI
{
	[SerializeField]
	[Header("Progress UI")]
	private Image progressImage;

	private Tween currentTween;

	private Tween ScaleTween;

	public override void Recyle()
	{
	}

	public void Show()
	{
	}

	public void StartProgress(float time, UnityAction complete)
	{
	}

	public void StopProgress()
	{
	}
}
