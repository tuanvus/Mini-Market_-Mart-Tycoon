using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class PackagingBox : MovingObject
{
	[CompilerGenerated]
	private sealed class _003CIEPacking_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PackagingBox _003C_003E4__this;

		public List<Product> products;

		public UnityAction finish;

		private float _003CjumpForce_003E5__2;

		private int _003Cindex_003E5__3;

		private float _003CdelayTime_003E5__4;

		private int _003Ci_003E5__5;

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
		public _003CIEPacking_003Ed__4(int _003C_003E1__state)
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
	private PackagingBoxAnimation animationController;

	[SerializeField]
	private List<Transform> slots;

	private List<Product> packagedProducts;

	public void Pack(List<Product> products, UnityAction finish)
	{
	}

	[IteratorStateMachine(typeof(_003CIEPacking_003Ed__4))]
	private IEnumerator IEPacking(List<Product> products, UnityAction finish)
	{
		return null;
	}

	public void Clear()
	{
	}
}
