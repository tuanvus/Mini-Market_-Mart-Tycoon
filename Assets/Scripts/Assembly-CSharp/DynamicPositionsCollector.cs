using UnityEngine;

public class DynamicPositionsCollector : StackCollector
{
	[Header("Dynamic position collector")]
	[SerializeField]
	private Transform rootPosition;

	[SerializeField]
	private float objectDistance;

	[SerializeField]
	private float stackDistance;

	[SerializeField]
	private float maxObjectDistance;

	[SerializeField]
	private int maxObjectCanCollect;

	[SerializeField]
	private int maxObjectInStack;

	public override bool CanCollect => false;

	protected override Vector3 GetLocalPushPosition()
	{
		return default(Vector3);
	}

	private Vector3 GetCollectPosition(int stackIndex, int objectStackIndex)
	{
		return default(Vector3);
	}

	protected override Vector3 GetMaxPosition()
	{
		return default(Vector3);
	}

	protected override void ReorderObjects()
	{
	}

	public override void SetUpgradeLevel(int level)
	{
	}

	public int GetMaxStack(int upgradeLevel)
	{
		return 0;
	}
}
