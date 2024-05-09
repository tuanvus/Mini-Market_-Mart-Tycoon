using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

public class ScaleObject : MonoBehaviour
{
	[SerializeField]
	private float timeScale;

	[SerializeField]
	private Vector3 OriginalScale;

	[SerializeField]
	private Vector3 TargetScale;

	[SerializeField]
	private Ease upEase;

	[SerializeField]
	private Ease downEase;

	private Tween tween;

	private void Start()
	{
	}

	public void ScaleUp(UnityAction finish = null)
	{
	}

	public void ScaleDown(UnityAction finish = null)
	{
	}

	public void ResetSize()
	{
	}
}
