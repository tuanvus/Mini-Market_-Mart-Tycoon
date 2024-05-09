using System.Collections.Generic;
using UCExtension.Common;
using UnityEngine;

public class MartManager : Service
{
	[SerializeField]
	private int mapIndex;

	[SerializeField]
	[Header("Objects")]
	private Camera _mCamera;

	[SerializeField]
	private Player player;

	[SerializeField]
	private AudioClip gameBGAudio;

	[Header("Bot support")]
	[SerializeField]
	private List<RecyleBinWorkPlace> recyleBinWorkPlaces;

	[SerializeField]
	private List<CashierDesk> cashierDesks;

	[SerializeField]
	private List<StoreShelf> stores;

	[Header("Data identifier")]
	[SerializeField]
	private List<DataIdentifier> dataIdentifiers;

	[SerializeField]
	private List<UnlockFeatureZone> unlockFeatureZones;

	[SerializeField]
	private List<TutorialFocus> tutorials;

	public int MapIndex => 0;

	public Camera MainCamera => null;

	public Player MainPlayer => null;

	private void Start()
	{
	}

	public RecyleBinWorkPlace FindNearestRecyleBin()
	{
		return null;
	}

	public CashierDesk GetNearestCashierDesk()
	{
		return null;
	}

	public CashierDesk GetRichestCashierDesk()
	{
		return null;
	}

	public StoreShelf GetStore(int productID)
	{
		return null;
	}
}
