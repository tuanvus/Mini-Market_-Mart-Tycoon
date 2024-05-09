using System;
using System.Collections.Generic;
using UCExtension.Common;
using UnityEngine;
using UnityEngine.UI;

public class PlayGUI : Service
{
	[SerializeField]
	private ControlPositionJoyStick joystickController;

	[SerializeField]
	private List<Joystick> joysticks;

	[SerializeField]
	private Canvas mainCavas;

	[SerializeField]
	private RectTransform worldFollowerParent;

	[SerializeField]
	private ControlJoyStickType defaultJoystick;

	[SerializeField]
	private Button SettingButton;

	[SerializeField]
	private Button UpgradeButton;

	[SerializeField]
	private Button ShopButton;

	[SerializeField]
	private Button CarButton;

	[SerializeField]
	private Button martIncomeButton;

	[SerializeField]
	private Button BuffPlayerSpeedButton;

	[SerializeField]
	private Button BuffShelverSpeedbutton;

	[SerializeField]
	private Button BuffCustomerSpeedButton;

	[SerializeField]
	private Button X2CoinEarnfor5MinButton;

	[SerializeField]
	private Button AdsToCoinsButton;

	[SerializeField]
	private List<Image> joystickImages;

	[SerializeField]
	private InterAdsWaiter adsWaiter;

	[SerializeField]
	private Text carStayingTimeText;

	[SerializeField]
	private EmojiUI emojiPrefab;

	public static Action OnShowCarOrderEvent;

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void RegisterEvents()
	{
	}

	private void UnregisterEvents()
	{
	}

	private void OnClickSettingButton()
	{
	}

	private void OnClickUpgradeButtonButton()
	{
	}

	private void OnClickShopButton()
	{
	}

	private void OnClickCarButton()
	{
	}

	private void OnClickMartIncomeButton()
	{
	}

	private void ShowCarButton()
	{
	}

	private void HideCarButton()
	{
	}

	private void TickCarTime(float time)
	{
	}

	private void OnJoyStickChange()
	{
	}

	private void OnClickBuffPlayerSpeedButton()
	{
	}

	private void OnClickBuffShelverSpeedbutton()
	{
	}

	private void OnClickBuffCustomerSpeedButton()
	{
	}

	private void OnClickX2CoinEarnfor5MinButton()
	{
	}

	private void OnClickAdsToCoinsButton()
	{
	}

	public void SetJoyStick(ControlJoyStickType type)
	{
	}

	public void SetFixed()
	{
	}

	public void SetDynamic()
	{
	}

	public Vector2 GetAnchorPos(RectTransform UIElementParent, Vector3 position)
	{
		return default(Vector2);
	}

	public void AddCoin(int coin)
	{
	}
}
