using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace UCExtension.UI
{
	public class JumpAndShakeAnim : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CIEDoEffect_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public JumpAndShakeAnim _003C_003E4__this;

			private int _003CnumShake_003E5__2;

			private int _003Ci_003E5__3;

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
			public _003CIEDoEffect_003Ed__22(int _003C_003E1__state)
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
		private bool autoPlay;

		[SerializeField]
		private Vector3 stretchScale;

		[SerializeField]
		private Vector3 stretchScale2;

		[SerializeField]
		private Vector2 step1Pivot;

		[SerializeField]
		private Vector2 step2Pivot;

		[SerializeField]
		private float moveDistance;

		[SerializeField]
		private float shakeAngle;

		private Vector3 normalScale;

		private float timeStretch;

		private float timeStretch2;

		private float timeDelay;

		private float timeMove;

		private float timeMove2;

		private float timeShake;

		private Ease moveUpEase;

		private Ease moveDownEase;

		private RectTransform rect;

		private Vector3 originalPos;

		private Sequence sequence;

		private IEnumerator currentEffect;

		private void Awake()
		{
		}

		public void PlayEffect()
		{
		}

		[IteratorStateMachine(typeof(_003CIEDoEffect_003Ed__22))]
		private IEnumerator IEDoEffect()
		{
			return null;
		}

		public void StopEffect()
		{
		}
	}
}
