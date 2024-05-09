using System.Collections.Generic;
using UnityEngine;

public class FixedPositionsCollector : StackCollector
{
	[SerializeField]
	private List<Transform> collectPositions;

	public override bool CanCollect => false;

	protected override Vector3 GetMaxPosition()
	{
		return default(Vector3);
	}

	protected override Vector3 GetLocalPushPosition()
	{
		return default(Vector3);
	}

	protected override void ReorderObjects()
	{
	}

	public void GetPositions()
	{
	}
}
