using System.Collections.Generic;
using UnityEngine;

public class UIMultiRequirement : TransformFollowerUI
{
	[SerializeField]
	private Transform rootRequirements;

	[SerializeField]
	private RequirementItem requirementItemprefab;

	private List<RequirementItem> spawnedItems;

	public void UpdateList(List<ProductRequirement> requirements)
	{
	}
}
