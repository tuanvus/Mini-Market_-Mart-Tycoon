using System.Runtime.CompilerServices;
using UnityEngine;
using dynamicscroll;

public class SelectLevelItemRow : DynamicScrollObject<ListSelectLevelItemData>
{
	[SerializeField]
	private Transform selectLevelItemParent;

	private bool isInit;

	public override float CurrentHeight
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public override float CurrentWidth
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public void Awake()
	{
	}

	public override void UpdateScrollObject(ListSelectLevelItemData item, int index)
	{
	}

	public void Init(ListSelectLevelItemData item)
	{
	}

	public void SetUp(ListSelectLevelItemData item)
	{
	}

	public SelectLevelItemRow()
	{
		((DynamicScrollObject<>)(object)this)._002Ector();
	}
}
