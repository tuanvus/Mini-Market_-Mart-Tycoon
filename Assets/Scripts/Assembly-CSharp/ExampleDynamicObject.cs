using System.Runtime.CompilerServices;
using UnityEngine.UI;
using dynamicscroll;

public class ExampleDynamicObject : DynamicScrollObject<ExampleData>
{
	private Text idText;

	private Text nameEmailText;

	private Text bodyText;

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

	public override void UpdateScrollObject(ExampleData item, int index)
	{
	}

	public ExampleDynamicObject()
	{
		((DynamicScrollObject<>)(object)this)._002Ector();
	}
}
