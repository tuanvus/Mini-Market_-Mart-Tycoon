using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SRDebugger;
using UnityEngine;

public class SROptions : INotifyPropertyChanged
{
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
	public sealed class DisplayNameAttribute : System.ComponentModel.DisplayNameAttribute
	{
		public DisplayNameAttribute(string displayName)
		{
		}
	}

	[AttributeUsage(AttributeTargets.Property)]
	public sealed class IncrementAttribute : SRDebugger.IncrementAttribute
	{
		public IncrementAttribute(double increment)
			: base(0.0)
		{
		}
	}

	[AttributeUsage(AttributeTargets.Property)]
	public sealed class NumberRangeAttribute : SRDebugger.NumberRangeAttribute
	{
		public NumberRangeAttribute(double min, double max)
			: base(0.0, 0.0)
		{
		}
	}

	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
	public sealed class SortAttribute : SRDebugger.SortAttribute
	{
		public SortAttribute(int priority)
			: base(0)
		{
		}
	}

	private static readonly SROptions _current;

	private int _gold;

	public static SROptions Current => null;

	[Category("Hack Gold")]
	public int Gold
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public event SROptionsPropertyChanged PropertyChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private event PropertyChangedEventHandler InterfacePropertyChangedEventHandler
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private event PropertyChangedEventHandler System_002EComponentModel_002EINotifyPropertyChanged_002EPropertyChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
	public static void OnStartup()
	{
	}

	public void OnPropertyChanged(string propertyName)
	{
	}

	[Category("Hack Gold")]
	public void SetGold()
	{
	}
}
