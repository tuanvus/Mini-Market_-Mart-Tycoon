using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeTab : MonoBehaviour
{
	[SerializeField]
	private Sprite bgSprite;

	[SerializeField]
	private Sprite itemBGSprite;

	public Action<UpgradeTab> OnSelectTab;

	public Image imgTab;

	public Sprite spriteSelect;

	public Sprite spriteDeSelect;

	private bool isSelected;

	public Text txt;

	public Color clrTxtOff;

	public Sprite BGSprite => null;

	public Sprite ItemBGSprite => null;

	public int Index
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private void Start()
	{
	}

	private void OnClick()
	{
	}

	public void SetIndex(int index)
	{
	}

	public void Deselect()
	{
	}

	public void Select()
	{
	}
}
