using System;
using System.Collections.Generic;
using UCExtension.Common;
using UnityEngine;
using UnityEngine.Events;

public class DataManager : Singleton<DataManager>
{
	[SerializeField]
	private int defaultCoin;

	[SerializeField]
	private ListHatData listHatData;

	[SerializeField]
	private List<MapUpgradeDatas> mapUpgradeDatas;

	public HatData defaultHat;

	public List<HatData> defaultUnlockedHats;

	public static UnityAction OnCoinChange;

	public static UnityAction OnWarningMoneyEvent;

	public static UnityAction OnUsedCoinNumChange;

	public static UnityAction OnTurnOnOffJoystick;

	public static UnityAction<HatData> OnCurrentHatChange;

	public static UnityAction<string> OnActiveBuff;

	public static UnityAction<string> OnDeactiveBuff;

	public int MapCount => 0;

	public ListHatData ListHatData => null;

	public int Coin
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public int TotalCoinEarned
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int NumShowInter
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsFirstSetup
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ShowJoystick
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool CanVibrate
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string SelectedHatID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public HatData SelectedHat => null;

	protected override void Awake()
	{
	}

	public void EarnMoneyInMap(int money)
	{
	}

	public void EarnMoney(int money)
	{
	}

	public bool UseCoin(int money)
	{
		return false;
	}

	public bool UseCoinInMap(int money)
	{
		return false;
	}

	public int GetCoinEarnedInMap(int mapIndex)
	{
		return 0;
	}

	private void IncreaseMoneyEarnInMap(int mapIndex, int value)
	{
	}

	public int GetCoinUsedInMap(int mapIndex)
	{
		return 0;
	}

	private void IncreaseCoinUsedInMap(int mapIndex, int value)
	{
	}

	public int GetTimeCollectMapRewardCountDown(int mapIndex)
	{
		return 0;
	}

	public DateTime LastTimeCollectMapReward(int mapIndex)
	{
		return default(DateTime);
	}

	public void CollectMapReward(int mapIndex)
	{
	}

	public int GetTotalMapProgress(int mapIndex)
	{
		return 0;
	}

	public void SetTotalMapProgress(int mapIndex, int value)
	{
	}

	public float GetMapProgressPercent(int mapIndex)
	{
		return 0f;
	}

	public int GetMapProgress(int mapIndex)
	{
		return 0;
	}

	public void IncreaseCurrentMapProgress(int mapIndex)
	{
	}

	public MapUpgradeDatas GetMapUpgradeDatas(int mapIndex)
	{
		return null;
	}

	public bool IsMapUnlocked(int mapIndex)
	{
		return false;
	}

	public void UnlockMap(int mapIndex)
	{
	}

	public DataManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
