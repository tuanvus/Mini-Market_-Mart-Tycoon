using DG.Tweening;
using UCExtension.Common;
using UnityEngine;
using UnityEngine.Events;

public class MovingObject : RecylableObject
{
	[SerializeField]
	protected Transform mainRender;

	private const float timeScaleUp = 0.5f;

	private Tween movingTween;

	private Tween scaleTween;

	private Tween rotateTween;

	protected void ScaleUp()
	{
	}

	public void WorldRotate(Vector3 targetRotation, float time = 0.5f)
	{
	}

	public void LocalRotate(Vector3 targetRotation, float time = 0.5f)
	{
	}

	public void WorldRecyleJump(Vector3 targetPosition, float time = 0.5f)
	{
	}

	public void ImpressScale()
	{
	}

	public void LocalRecyleJump(Vector3 targetPosition, float time = 0.5f)
	{
	}

	public void ScaleDownAndRecyle(float time = 0.5f)
	{
	}

	public void SetLocalPosition(Vector3 targetPosition)
	{
	}

	public void SetPosition(Vector3 targetPosition)
	{
	}

	public void LocalJump(Vector3 targetPosition, float time = 0.3f, float force = 1f, UnityAction finish = null)
	{
	}

	public void Jump(Vector3 targetPosition, float time = 0.3f, float force = 5f, UnityAction finish = null)
	{
	}
}
