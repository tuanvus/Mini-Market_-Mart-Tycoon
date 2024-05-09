using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Firebase.Analytics;
using UnityEngine;
using UnityEngine.Events;

namespace API.LogEvent
{
	public class LogEventManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CIEWaitCheckAndFixDependencies_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LogEventManager _003C_003E4__this;

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
			public _003CIEWaitCheckAndFixDependencies_003Ed__6(int _003C_003E1__state)
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
		private sealed class _003CIEWaitForInitFirebase_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CIEWaitForInitFirebase_003Ed__21(int _003C_003E1__state)
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

		public static LogEventManager Ins;

		public bool IsUseFirebaseLogEvent;

		public bool IsUseAdjust;

		public bool IsUseFacebook;

		public bool IsUseDebug;

		private void Awake()
		{
		}

		[IteratorStateMachine(typeof(_003CIEWaitCheckAndFixDependencies_003Ed__6))]
		private IEnumerator IEWaitCheckAndFixDependencies()
		{
			return null;
		}

		public void InitializeFirebase()
		{
		}

		private void OnEnable()
		{
		}

		public void OnLevelCompleteLogEvent(string levelName)
		{
		}

		public void OnLevelStartLogEvent(string levelName)
		{
		}

		public void OnUseItemLog(string ItemName, string levelName)
		{
		}

		public void OnApplovinAdsRevenuePaid(MaxSdkBase.AdInfo adInfo)
		{
		}

		public void OnInterstitialNumReach(string adjustEventId, int numReach)
		{
		}

		public void OnCallShowInterstitialAds(bool HasAds, string placement)
		{
		}

		public void OnRewardedVideoNumReach(string adjustEventId, int numReach)
		{
		}

		public void OnCallShowRewardedVideoAds(bool HasAds, string placement)
		{
		}

		public void LogFirebaseEvent(string eventName)
		{
		}

		public void LogFirebaseEvent(string eventName, Parameter[] param = null)
		{
		}

		public void LogFirebaseEvent(string eventName, Parameter param = null)
		{
		}

		private void WaitForFirebaseInit(UnityAction finish)
		{
		}

		[IteratorStateMachine(typeof(_003CIEWaitForInitFirebase_003Ed__21))]
		private IEnumerator IEWaitForInitFirebase(UnityAction finish)
		{
			return null;
		}

		public string NormalizeEventName(string eventName)
		{
			return null;
		}
	}
}
