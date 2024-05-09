using System.Collections.Generic;
using UCExtension.GUI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MartIncomeGUI : BaseGUI
{
	[SerializeField]
	private MartIncomItemUI itemPrefab;

	[SerializeField]
	private Transform itemParent;

	[SerializeField]
	private List<Button> closeButtons;

	private List<MartIncomItemUI> spawnedItems;

	protected override void SetUp()
	{
	}

	public override void Open(object[] initParams, UnityAction finish = null)
	{
	}

	private void SetUpItems()
	{
	}

	public void OnClickCloseButton()
	{
	}

	public void OnGoToMap(int mapIndex)
	{
	}
}
