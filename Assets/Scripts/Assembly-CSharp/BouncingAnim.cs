using DG.Tweening;
using UnityEngine;

public class BouncingAnim : MonoBehaviour
{
	[SerializeField]
	private bool autoPlay;

	[SerializeField]
	private bool Loop;

	private bool played;

	[SerializeField]
	private float originalScale;

	[SerializeField]
	private float delayTimePerLoop;

	[SerializeField]
	private float softScale;

	[SerializeField]
	private int numberOfBounc;

	[SerializeField]
	private float startBouncPower;

	[SerializeField]
	private float firstBouncTime;

	private Tween bouncingTween;

	private void OnEnable()
	{
	}

	public void PlayAnim()
	{
	}

	public void StopAnim()
	{
	}

	public void AutoSetUp()
	{
	}
}
