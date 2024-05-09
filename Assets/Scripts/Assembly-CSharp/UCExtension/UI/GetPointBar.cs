using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UCExtension.Common;
using UnityEngine;
using UnityEngine.Events;

namespace UCExtension.UI
{
	public class GetPointBar : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CIEPlayGetPointEffect_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GetPointBar _003C_003E4__this;

			public UnityAction stepFinish;

			public int quantities;

			public Vector3 pos;

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
			public _003CIEPlayGetPointEffect_003Ed__9(int _003C_003E1__state)
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
		private Transform icon;

		[SerializeField]
		private RecylableObject iconPrefab;

		[SerializeField]
		private float jumpPower;

		[SerializeField]
		private float jumpRange;

		private float timeIncrease;

		private float totalTimeRoot;

		private Sequence iconSeq;

		private float timeDelay;

		public void PlayGetPointEffect(Vector3 pos, int quantities, UnityAction stepFinish = null, UnityAction finish = null)
		{
		}

		[IteratorStateMachine(typeof(_003CIEPlayGetPointEffect_003Ed__9))]
		private IEnumerator IEPlayGetPointEffect(Vector3 pos, int quantities, UnityAction stepFinish = null, UnityAction finish = null)
		{
			return null;
		}
	}
}
