using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class HatItem : MonoBehaviour
{
	public bool IsSelected;

	private Button m_Button;

	[SerializeField]
	private Image iconImage;

	[SerializeField]
	private Image bgImage;

	[SerializeField]
	private GameObject SelectedFrame;

	[SerializeField]
	private GameObject coinGroup;

	[SerializeField]
	private GameObject adsGroup;

	[SerializeField]
	private Text coinValueText;

	private HatData currentData;

	public Action<HatItem> OnSelected;

	private bool isSelected;

	public GameObject iconUnlock;

	public ItemData Skin
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public HatData CurrentData => null;

	private void Awake()
	{
	}

	public void SetUp(HatData data)
	{
	}

	private void OnClickButton()
	{
	}

	public void Select(bool isSelect)
	{
	}

	public void UnlockByCoin()
	{
	}

	public void UnlockByAds()
	{
	}

	public void Unlock()
	{
	}
}
