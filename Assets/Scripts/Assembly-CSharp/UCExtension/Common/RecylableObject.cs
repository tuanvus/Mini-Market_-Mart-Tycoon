using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UCExtension.Common
{
	[DisallowMultipleComponent]
	public class RecylableObject : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CIEAutoRecyle_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RecylableObject _003C_003E4__this;

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
			public _003CIEAutoRecyle_003Ed__11(int _003C_003E1__state)
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

		[Header("Recylable object")]
		[SerializeField]
		private bool isAutoRecyle;

		[SerializeField]
		private float timeAutoRecyle;

		private string poolName;

		private bool isAvailabe;

		protected bool IsAvailable
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public string PoolName => null;

		public virtual void OnSpawn()
		{
		}

		public void SetPoolName(string originalName)
		{
		}

		[IteratorStateMachine(typeof(_003CIEAutoRecyle_003Ed__11))]
		private IEnumerator IEAutoRecyle()
		{
			return null;
		}

		public virtual void Recyle()
		{
		}
	}
}
