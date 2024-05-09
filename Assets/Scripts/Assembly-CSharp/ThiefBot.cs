using System;
using System.Runtime.CompilerServices;
using UCExtension.Common;
using UnityEngine;

public class ThiefBot : Bot<ThiefBot>
{
	[SerializeField]
	private TutorialFocus tutorialFocus;

	[SerializeField]
	private RecylableObject disapearEffect;

	public Action OnDisapear;

	public int DesiredAmount
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

	public bool IsCaught
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public TutorialFocus TutorialFocus => null;

	public CashierDesk StealDesk
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

	protected override void Awake()
	{
	}

	public override void OnSpawn()
	{
	}

	public void SetStealDesk(CashierDesk desk)
	{
	}

	public override void Recyle()
	{
	}

	public void OnCaught()
	{
	}

	protected override void OnStartMove()
	{
	}

	protected override void OnStopMove()
	{
	}

	public ThiefBot()
	{
		((Bot<>)(object)this)._002Ector();
	}
}
