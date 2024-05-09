using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeUIItem : MonoBehaviour
{
	[SerializeField]
	private UpgradeData Obj;

	[SerializeField]
	private StatsName statName;

	[SerializeField]
	private Text myUpgradeStatusText;

	[SerializeField]
	private Text coinValueText;

	[SerializeField]
	private Button upgradeByCoinButton;

	[SerializeField]
	private Button upgradeByAdsButton;

	[SerializeField]
	private Image maxedUpgrade;

	private int cost;

	private void Start()
	{
	}

	public void SetObj(UpgradeData obj)
	{
	}

	public void LockedStatus()
	{
	}

	public void ResetStatus()
	{
	}

	private void OnReset(int currentLevel, List<UpgradeLevel> list, string LvText)
	{
	}

	private void OnClickUpgradeByCoinButton()
	{
	}

	private void OnClickUpgradeByAdsButton()
	{
	}

	private void UpgradeObj()
	{
	}
}
