using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class TransitCar : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CIEFillContainer_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TransitCar _003C_003E4__this;

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
		public _003CIEFillContainer_003Ed__10(int _003C_003E1__state)
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
	private float delayTransportTime;

	[SerializeField]
	private Car car;

	[SerializeField]
	private ProductContainer container;

	[SerializeField]
	private Transform spawnPosition;

	private bool isTransporting;

	private float timeLeave;

	private void Start()
	{
	}

	protected void Update()
	{
	}

	public void TransportProduct()
	{
	}

	private void FillContainer(UnityAction finish = null)
	{
	}

	[IteratorStateMachine(typeof(_003CIEFillContainer_003Ed__10))]
	private IEnumerator IEFillContainer(UnityAction finish = null)
	{
		return null;
	}
}
