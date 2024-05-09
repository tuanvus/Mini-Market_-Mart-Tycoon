using System;
using UnityEngine;

public class BotMover : NavMeshAgentController
{
	[SerializeField]
	private float walkRadius;

	[SerializeField]
	private float baseMovementSpeed;

	[SerializeField]
	private float speedIncrease;

	public Action OnStopMove;

	public Action OnStartMove;

	private bool isMoving;

	private void Update()
	{
	}

	public void SetDestination(Vector3 targetPosition)
	{
	}

	public void MoveToRandomPosition()
	{
	}

	public Vector3 GetReachablePosition(Vector3 position)
	{
		return default(Vector3);
	}

	public void SetUpgradeLevel(int level)
	{
	}

	public float GetSpeed(int upgradeLevel)
	{
		return 0f;
	}

	public float GetInteractableRange()
	{
		return 0f;
	}

	public void SetSpeed(float speed)
	{
	}
}
