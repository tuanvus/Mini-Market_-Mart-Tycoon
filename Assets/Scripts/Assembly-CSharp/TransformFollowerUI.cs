using DG.Tweening;
using UCExtension.Common;
using UnityEngine;

public class TransformFollowerUI : RecylableObject
{
	[SerializeField]
	private bool notFollowByTransform;

	private RectTransform rect;

	private Transform target;

	private RectTransform parent;

	private Vector2 targetAnchorPos;

	private Tween tween;

	private Vector3 targetPosition;

	protected virtual void Awake()
	{
	}

	private void Start()
	{
	}

	public TransformFollowerUI ResetTransform()
	{
		return null;
	}

	public TransformFollowerUI SetParent(RectTransform parent)
	{
		return null;
	}

	public TransformFollowerUI SetFollowTarget(Transform target)
	{
		return null;
	}

	public TransformFollowerUI ResetPos()
	{
		return null;
	}

	protected virtual void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void Follow()
	{
	}

	public void ScaleUp()
	{
	}

	public void ScaleDown()
	{
	}

	private Vector2 GetAnchorPos()
	{
		return default(Vector2);
	}
}
