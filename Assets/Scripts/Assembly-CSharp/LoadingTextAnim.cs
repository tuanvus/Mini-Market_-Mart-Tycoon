using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class LoadingTextAnim : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CIEPlayAnim_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoadingTextAnim _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CIEPlayAnim_003Ed__7(int _003C_003E1__state)
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
	private Text mainText;

	[SerializeField]
	private string prefix;

	[SerializeField]
	private string parttern;

	[SerializeField]
	private int loop;

	[SerializeField]
	private float time;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CIEPlayAnim_003Ed__7))]
	private IEnumerator IEPlayAnim()
	{
		return null;
	}
}
