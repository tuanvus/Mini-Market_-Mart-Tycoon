using UnityEngine;

public class PlayerMover : NavMeshAgentController
{
	[SerializeField]
	private Transform mainBody;

	[SerializeField]
	private float baseMovementSpeed;

	[SerializeField]
	private float speedIncrease;

	[SerializeField]
	private float rotationSpeed;

	private Quaternion targetRotation;

	private float movementSpeed;

	private void Start()
	{
	}

	public void OnChangeMovementInput(Vector2 movementInput)
	{
	}

	private void FixedUpdate()
	{
	}

	public void SetUpgradeLevel(int level)
	{
	}

	public void StopRotation()
	{
	}

	public float GetSpeed(int upgradeLevel)
	{
		return 0f;
	}
}
