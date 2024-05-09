using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UCExtension.Common;

public class GameManager : Singleton<GameManager>
{
	[CompilerGenerated]
	private sealed class _003CIELoadMap_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int mapIndex;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CIELoadMap_003Ed__5(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public int CurrentMapIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	public void LoadMap(int index)
	{
	}

	[IteratorStateMachine(typeof(_003CIELoadMap_003Ed__5))]
	private IEnumerator IELoadMap(int mapIndex)
	{
		return null;
	}

	public void Vibrate()
	{
	}

	public GameManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
