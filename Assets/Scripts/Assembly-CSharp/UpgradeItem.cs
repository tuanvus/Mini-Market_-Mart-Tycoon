using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UpgradeItem : MonoBehaviour
{
	[SerializeField]
	private Image bgImage;

	[SerializeField]
	private Image iconImage;

	[SerializeField]
	private Text ownerText;

	[SerializeField]
	private Text nameText;

	[SerializeField]
	private Text upgradePriceText;

	[SerializeField]
	private Button adsUpgradeButton;

	[SerializeField]
	private Button coinUpgradeButton;

	[SerializeField]
	private GameObject maxObject;

	[SerializeField]
	private GameObject lockedGroup;

	private UpgradeData currentData;

	public UnityAction OnUpgrade;

	private void Start()
	{
	}

	public void SetUp(UpgradeData data)
	{
	}

	public void ResetStates()
	{
	}

	private void UpgradeByAds()
	{
	}

	private void UpgradeByCoin()
	{
	}

	private void Upgrade()
	{
	}

	public void SetBG(Sprite bgSprite)
	{
	}
}
