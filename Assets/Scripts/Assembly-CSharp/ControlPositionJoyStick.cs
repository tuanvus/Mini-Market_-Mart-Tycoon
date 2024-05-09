using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class ControlPositionJoyStick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
{
	[SerializeField]
	protected Joystick _mJoyStick;

	[SerializeField]
	private bool disableWhenNotUse;

	protected RectTransform JoyStickParent;

	protected RectTransform JoyStickRect;

	protected EventSystem eventSystem;

	protected Canvas _mCanvas;

	protected RectTransform _mCanvasRect;

	protected Camera _mCamera;

	public static Action<Vector2> OnChangeMoveInput;

	private void Awake()
	{
	}

	public void SetMainJoyStick(Joystick joystick)
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	protected virtual void Init()
	{
	}

	protected virtual void OnPointerUpCallback()
	{
	}

	protected virtual void OnPointerDownCallback()
	{
	}

	protected virtual void OnDragCallback()
	{
	}

	public virtual void OnPointerUp(PointerEventData eventData)
	{
	}

	public virtual void OnPointerDown(PointerEventData eventData)
	{
	}

	public virtual void OnDrag(PointerEventData eventData)
	{
	}

	public Vector2 GetAnchorPos(RectTransform UIElementParent, Vector3 screenPos)
	{
		return default(Vector2);
	}

	private void OnApplicationFocus(bool focus)
	{
	}

	private void OnApplicationPause(bool pause)
	{
	}
}
