using UnityEngine;
using UnityEngine.UI;

public class RequirementUI : TransformFollowerUI
{
	[SerializeField]
	private Image iconImage;

	[SerializeField]
	private Text orderText;

	public void UpdateOrder(ProductRequirement order)
	{
	}

	public RequirementUI SetIcon(Sprite icon)
	{
		return null;
	}

	public RequirementUI SetText(string text)
	{
		return null;
	}
}
