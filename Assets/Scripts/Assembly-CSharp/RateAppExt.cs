using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Play.Common;
using Google.Play.Review;
using UnityEngine;

public class RateAppExt : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CIERequestReviewFlow_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RateAppExt _003C_003E4__this;

		private PlayAsyncOperation<PlayReviewInfo, ReviewErrorCode> _003CrequestFlowOperation_003E5__2;

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
		public _003CIERequestReviewFlow_003Ed__10(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CIEShowReviewFlow_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RateAppExt _003C_003E4__this;

		private PlayAsyncOperation<VoidResult, ReviewErrorCode> _003ClaunchFlowOperation_003E5__2;

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
		public _003CIEShowReviewFlow_003Ed__11(int _003C_003E1__state)
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

	private ReviewManager reviewManager;

	private static RateAppExt instance;

	private bool isShowingIAR;

	private PlayReviewInfo _playReviewInfo;

	private bool isReviewAvailable;

	public static RateAppExt Instance => null;

	[RuntimeInitializeOnLoadMethod]
	public static void FirstLoadReview()
	{
	}

	public void ShowInAppReview()
	{
	}

	public void RequestReviewFlow()
	{
	}

	[IteratorStateMachine(typeof(_003CIERequestReviewFlow_003Ed__10))]
	private IEnumerator IERequestReviewFlow()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CIEShowReviewFlow_003Ed__11))]
	private IEnumerator IEShowReviewFlow()
	{
		return null;
	}

	private void Update()
	{
	}
}
