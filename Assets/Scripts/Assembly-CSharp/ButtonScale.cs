using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class ButtonScale : Button
{
	private enum ButtonScaleType
	{
		ZoomIn = 0,
		ZoomOut = 1
	}

	private ButtonScaleType scaleType;

	private bool isPressed;

	private float zoomInScale;

	private float zoomSpeed;

	public static UnityAction<string> OnClickButtonCallback;

	public UnityAction OnPointerDownCallback;

	public override void OnPointerClick(PointerEventData eventData)
	{
	}

	public override void OnPointerDown(PointerEventData eventData)
	{
	}

	public override void OnPointerUp(PointerEventData eventData)
	{
	}

	private void LateUpdate()
	{
	}
}
