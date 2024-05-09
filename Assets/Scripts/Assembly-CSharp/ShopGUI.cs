using UCExtension.GUI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ShopGUI : BaseGUI
{
	[SerializeField]
	private Transform itemParent;

	[SerializeField]
	private HatItem hatItemPrefab;

	[SerializeField]
	private Button CloseButton;

	[SerializeField]
	private PlayerSkinController playerSkinController;

	private HatItem selectedHatItem;

	public override void Open(object[] initParams, UnityAction finish = null)
	{
	}

	private void Start()
	{
	}

	public void FirstSetUp()
	{
	}

	private void OnSelectHatItem(HatItem item)
	{
	}

	private void OnSkinChange(HatData data)
	{
	}

	private void OnClickExit()
	{
	}
}
