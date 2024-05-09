using System.Collections.Generic;
using UCExtension.GUI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PhoneOrderGUI : BaseGUI
{
	[SerializeField]
	private Button closeButton;

	[SerializeField]
	private Button collectButton;

	[SerializeField]
	private Text rewardCoinText;

	[SerializeField]
	private Button multipleCollectButton;

	[SerializeField]
	private Transform rootRequirements;

	[SerializeField]
	private RequirementItem requirementItemPrefab;

	[SerializeField]
	private ContentSizeFitter contentSizeFitter;

	private List<RequirementItem> spawnedItems;

	public static UnityAction<float> OnCollect;

	protected override void SetUp()
	{
	}

	public override void Open(object[] initParams, UnityAction finish = null)
	{
	}

	public void UpdateList(List<ProductRequirement> requirements)
	{
	}

	private void OnClickCloseButton()
	{
	}

	private void OnClickCollectButton()
	{
	}

	private void OnClickMultipleCollectButton()
	{
	}
}
