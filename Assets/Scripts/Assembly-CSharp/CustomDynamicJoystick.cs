using UnityEngine;
using UnityEngine.EventSystems;

public class CustomDynamicJoystick : Joystick
{
	[SerializeField]
	private float moveThreshold;

	public float MoveThreshold
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public override void SetUp()
	{
	}

	public override void OnPointerDown(PointerEventData eventData)
	{
	}

	public override void OnPointerUp(PointerEventData eventData)
	{
	}

	protected override void HandleInput(float magnitude, Vector2 normalised, Vector2 radius, Camera cam)
	{
	}
}
