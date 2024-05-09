using System.Collections.Generic;
using UnityEngine;

public class CashierDesk : MonoBehaviour, IPlayerEnterTrigger, IPlayerExitTrigger
{
	[SerializeField]
	private Transform packagingBoxPosition;

	[SerializeField]
	private Transform thiefSlot;

	[SerializeField]
	private PackagingBox packagingBoxPrefab;

	[SerializeField]
	protected List<Transform> queuePositions;

	[SerializeField]
	private bool canCash;

	[SerializeField]
	private MoneyContainer moneyContainer;

	[SerializeField]
	private TutorialFocus tutorial;

	[SerializeField]
	private AudioClip cashAudio;

	private bool isPacking;

	private bool isPlayerStay;

	private bool hasCashier;

	private Queue<CustomerBot> queingCustomers;

	private bool canPay => false;

	public Transform ThiefSlot => null;

	public MoneyContainer MoneyContainer => null;

	protected void Update()
	{
	}

	public void TurnOnCashier()
	{
	}

	public PackagingBox SpawnPackagingBox()
	{
		return null;
	}

	public void Queue(CustomerBot customer)
	{
	}

	public void NextQueue()
	{
	}

	public void OnPlayerEnter(Player player)
	{
	}

	public void OnPlayerExit(Player player)
	{
	}
}
