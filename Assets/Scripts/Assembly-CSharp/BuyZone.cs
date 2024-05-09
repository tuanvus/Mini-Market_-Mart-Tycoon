using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BuyZone : SavableObject, IPlayerStayTrigger, IPlayerEnterTrigger, IPlayerExitTrigger
{
	[Header("Buy zone")]
	[SerializeField]
	private bool defaultUnlocked;

	[SerializeField]
	private int originalPrice;

	[SerializeField]
	private AudioClip buyAudio;

	[SerializeField]
	private List<BuyZone> unlockConditionZone;

	[SerializeField]
	private Transform coinInput;

	[SerializeField]
	private MovingObject moneyPrefab;

	[SerializeField]
	private Transform requirementFollowTarget;

	[SerializeField]
	private RequirementUI requirementDisplayPrefab;

	[SerializeField]
	private TutorialFocus tutorial;

	protected RequirementUI currentDisplay;

	public Action OnBought;

	private int remainCoinToBuy;

	private float timePlayerEnter;

	public bool IsBought
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private int CoinToBuy
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	private void CheckToUnlock()
	{
	}

	private void UnLock()
	{
	}

	public void OnPlayerStay(Player player)
	{
	}

	protected virtual void FirstBuy()
	{
	}

	protected virtual void Buy()
	{
	}

	protected virtual void Lock()
	{
	}

	private bool CalculateCoin()
	{
		return false;
	}

	public void Save()
	{
	}

	public void Load()
	{
	}

	public void OnPlayerEnter(Player player)
	{
	}

	public void OnPlayerExit(Player player)
	{
	}
}
