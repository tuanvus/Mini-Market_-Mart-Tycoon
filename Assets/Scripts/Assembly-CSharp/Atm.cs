using UnityEngine;

public class Atm : MonoBehaviour, IPlayerEnterTrigger, IPlayerExitTrigger
{
	[Header("Atm")]
	[SerializeField]
	private float timeDelayShow;

	[SerializeField]
	private float timeWaitShowAds;

	[SerializeField]
	private Transform popupFollowPosition;

	[SerializeField]
	private AtmProgressUI popupPrefab;

	[SerializeField]
	private Transform moneySpawnPosition;

	[SerializeField]
	private Product moneyPrefab;

	[SerializeField]
	private int test;

	[SerializeField]
	private AudioClip getMoneyAudio;

	private AtmProgressUI currentPopup;

	private float lastTimeShowAds;

	private int moneyReward;

	private Player stayingPlayer;

	private void Start()
	{
	}

	public void OnPlayerEnter(Player player)
	{
	}

	public void OnPlayerExit(Player player)
	{
	}

	private void ShowAdsPopup()
	{
	}

	private int GetCoinByUsedCoin(int usedCoin)
	{
		return 0;
	}

	private void OnGetMoney()
	{
	}
}
