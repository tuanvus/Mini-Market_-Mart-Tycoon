using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class NestedChildScrollRect : ScrollRect
{
	private ScrollRect _parentScroll;

	private bool _draggingParent;

	protected override void Awake()
	{
	}

	private ScrollRect GetScrollParent(Transform t)
	{
		return null;
	}

	private bool IsPotentialParentDrag(Vector2 inputDelta)
	{
		return false;
	}

	public override void OnInitializePotentialDrag(PointerEventData eventData)
	{
	}

	public override void OnBeginDrag(PointerEventData eventData)
	{
	}

	public override void OnDrag(PointerEventData eventData)
	{
	}

	public override void OnEndDrag(PointerEventData eventData)
	{
	}
}
