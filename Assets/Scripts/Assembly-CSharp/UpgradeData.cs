using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UpgradeableData", menuName = "Data/UpgradeableData")]
public class UpgradeData : ItemData
{
	public string OwnerName;

	public List<UpgradeLevel> UpgradeLevelDatas;

	public static Action<UpgradeData> OnUpgrade;

	public int Level
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}
}
