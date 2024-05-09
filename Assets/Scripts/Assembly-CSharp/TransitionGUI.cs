using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UCExtension.Common;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TransitionGUI : Singleton<TransitionGUI>
{
	[CompilerGenerated]
	private sealed class _003CIETransition_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TransitionGUI _003C_003E4__this;

		public UnityAction onEndClose;

		public UnityAction onStartOpen;

		public UnityAction finish;

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
		public _003CIETransition_003Ed__9(int _003C_003E1__state)
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

	[SerializeField]
	private float timeShow;

	[SerializeField]
	private float timeWait;

	[SerializeField]
	private Image curtain;

	public bool IsShowing
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private void Start()
	{
	}

	public void ShowTransition(UnityAction onEndClose = null, UnityAction onStartOpen = null, UnityAction finish = null)
	{
	}

	[IteratorStateMachine(typeof(_003CIETransition_003Ed__9))]
	private IEnumerator IETransition(UnityAction onEndClose = null, UnityAction onStartOpen = null, UnityAction finish = null)
	{
		return null;
	}

	public TransitionGUI()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
