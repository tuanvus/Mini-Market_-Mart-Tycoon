using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class Timer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CIEHourCountDown_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Timer _003C_003E4__this;

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
		public _003CIEHourCountDown_003Ed__9(int _003C_003E1__state)
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
	private TimerType type;

	private Text countDownText;

	private IEnumerator ieCountDown;

	private bool isStop;

	private int currentSecond;

	public int CurrentSecond => 0;

	public void SetType(TimerType type)
	{
	}

	public void CountDown(int second, UnityAction finish = null)
	{
	}

	[IteratorStateMachine(typeof(_003CIEHourCountDown_003Ed__9))]
	private IEnumerator IEHourCountDown(UnityAction finish = null)
	{
		return null;
	}

	public void AddSecond(int second)
	{
	}

	public void StopCountDown(bool completely = false)
	{
	}

	public void ContinueCountDown()
	{
	}

	public string GetCountDownFormat(int second, TimerType type = TimerType.second)
	{
		return null;
	}
}
