using System;
using UnityEngine;

public class SevenPublisher : MonoBehaviour
{
	[SerializeField]
	private string apiKey;

	[SerializeField]
	private string sheetID;

	[SerializeField]
	private string sheetName;

	public bool UseFacebook;

	public string GoogleServiceFileID;

	public const int gameNameRowIndex = 1;

	public const int packageRowIndex = 2;

	public const int facebookNameRowIndex = 4;

	public const int facebookIDRowIndex = 5;

	public const int facebookTokenRowIndex = 6;

	public const int adsAppIDRowIndex = 8;

	public const int adsOpen1IDRowIndex = 9;

	public const int adsShowFullIDRowIndex = 10;

	public const int adsBannerIDRowIndex = 11;

	public const int adsRewardVideoIDRowIndex = 12;

	public const int adjustIDRowIndex = 14;

	public const int adjustBannerKeyRowIndex = 15;

	public const int adjustInterKeyRowIndex = 16;

	public const int adjustInterImpressionKeyRowIndex = 17;

	public const int adjustRewardKeyRowIndex = 18;

	public const int adjustRewardImpressionKeyRowIndex = 19;

	private string link => null;

	private void Start()
	{
	}

	public void ReadFromSheet(Action<SheetData> callback)
	{
	}

	public void OpenLink()
	{
	}
}
