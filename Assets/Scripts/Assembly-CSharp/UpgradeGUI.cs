using System.Collections.Generic;
using UCExtension.GUI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UpgradeGUI : BaseGUI
{
	[SerializeField]
	private GameObject mainPopup;

	[SerializeField]
	private float timeShowUpgrade;

	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private Button ExitButton;

	[SerializeField]
	private Transform upgradeItemsParent;

	[SerializeField]
	private UpgradeItem upgradeItemPrefab;

	[SerializeField]
	private List<UpgradeTab> tabs;

	[SerializeField]
	private AudioClip upgradeAudio;

	private List<UpgradeItem> upgradeItems;

	public UpgradeTab selectedTab;

	public GameObject bgshadow;

	private void Start()
	{
	}

	private void OnSelectedTab(UpgradeTab tab)
	{
	}

	public override void Open(object[] initParams, UnityAction finish = null)
	{
	}

	private void SetUpList(List<UpgradeData> datas)
	{
	}

	private void OnClickExitButton()
	{
	}

	private void OnUpgrade()
	{
	}
}
