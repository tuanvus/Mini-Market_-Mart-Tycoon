using System.Collections.Generic;
using UnityEngine;

public class FixedPositionProductContainer : ProductContainer, IPlayerEnterTrigger, IPlayerExitTrigger
{
	[SerializeField]
	private List<Transform> productSlots;

	[SerializeField]
	private RequirementUI uiRequirementPrefab;

	[SerializeField]
	private Transform requirementFollowTarget;

	[SerializeField]
	private int test;

	[SerializeField]
	private int capacity;

	private RequirementUI currentDisplay;

	private bool isSettedCapacity;

	private int MaxSlotCount => 0;

	public override bool CanPushProduct()
	{
		return false;
	}

	protected override Vector3 GetGenerateWorldPosition()
	{
		return default(Vector3);
	}

	protected override Vector3 GetGenerateWorldRotation()
	{
		return default(Vector3);
	}

	protected override void Start()
	{
	}

	public void GetPositions()
	{
	}

	private void UpdateDisplay()
	{
	}

	protected override void Save()
	{
	}

	protected override void Load()
	{
	}

	private ProductRequirement GetCurrentOrder()
	{
		return null;
	}

	public override void SetMaxCapcity(int capcity)
	{
	}

	public void OnPlayerExit(Player player)
	{
	}

	public new void OnPlayerEnter(Player player)
	{
	}
}
