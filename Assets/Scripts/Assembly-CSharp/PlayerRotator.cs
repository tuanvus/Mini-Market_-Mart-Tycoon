using UnityEngine;

public class PlayerRotator : MonoBehaviour
{
	[SerializeField]
	private Transform horizontalRotator;

	[SerializeField]
	private Transform verticalRotator;

	[SerializeField]
	private float rotationSpeed;

	[SerializeField]
	private float changeSpeed;

	[SerializeField]
	private float thresold;

	private Vector3 targetAngle;

	private float minXAngle;

	private float maxXAngle;

	public void ResetAngle()
	{
	}

	private void Update()
	{
	}

	public void OnChangeRotationInput(Vector2 deltaPosition)
	{
	}
}
