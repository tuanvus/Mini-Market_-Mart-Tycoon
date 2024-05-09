using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace API.Ads
{
	public class AdManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CWaitInitRemoveConfig_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AdManager _003C_003E4__this;

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
			public _003CWaitInitRemoveConfig_003Ed__23(int _003C_003E1__state)
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
		private sealed class _003CWaitInitFirebase_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AdManager _003C_003E4__this;

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
			public _003CWaitInitFirebase_003Ed__27(int _003C_003E1__state)
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
		private sealed class _003CCompleteMethodfull_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AdManager _003C_003E4__this;

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
			public _003CCompleteMethodfull_003Ed__59(int _003C_003E1__state)
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
		private sealed class _003CCompleteMethodAOA_003Ed__73 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AdManager _003C_003E4__this;

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
			public _003CCompleteMethodAOA_003Ed__73(int _003C_003E1__state)
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
		private sealed class _003CCompleteMethodRewardedVideo_003Ed__85 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AdManager _003C_003E4__this;

			public bool val;

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
			public _003CCompleteMethodRewardedVideo_003Ed__85(int _003C_003E1__state)
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

		public static AdManager Ins;

		public AdsSetting androidSetting;

		public AdsSetting iosSetting;

		private AdsSetting curSetting;

		public bool isUseFireBase;

		public bool CanInitFirebase;

		public string androidFirebaseKey;

		public string iosFirebaseKey;

		private bool IsAdsInited;

		private bool isAdsLeaveApp;

		private bool isAOAOff;

		private bool IsHideBanner;

		private int numInterShowed;

		private int numRewardShowed;

		public static Action OnInterShowed;

		public static Action OnVideoShowed;

		private int numClickBanner;

		private bool bannerLoaded;

		public bool isAutoLoadFull;

		private int curRetryFull;

		private int maxFullRetryCount;

		private float lastTimeShowFull;

		private int numClickFull;

		private UnityAction OnFullClosed;

		private int curCallNetworkTypeFull;

		private int curCallNumFull;

		private int tierIndex;

		private DateTime loadTime;

		private bool showFirstOpen;

		private bool isShowingAd;

		private UnityAction OnAOAClosed;

		private int numClickReward;

		private bool triggerCompleteMethod;

		private int currentRetryRewardedVideo;

		private int maxRetryCount;

		private UnityAction<bool> OnCompleteMethod;

		private int curCallNetworkTypeVideo;

		private int curCallNumVideo;

		private DateTime lastTimeRefocusShow;

		public bool IsAdsLeaveApp
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsAOAOff => false;

		private void Awake()
		{
		}

		private void LogID()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitInitRemoveConfig_003Ed__23))]
		private IEnumerator WaitInitRemoveConfig()
		{
			return null;
		}

		private void Start()
		{
		}

		private void OnFirebaseInitComplete()
		{
		}

		private void InitAds()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitInitFirebase_003Ed__27))]
		private IEnumerator WaitInitFirebase()
		{
			return null;
		}

		public void ShowBanner()
		{
		}

		public void HideBanner()
		{
		}

		private void RequestApplovinBanner()
		{
		}

		private void OnBannerAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnBannerAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnBannerAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnBannerAdFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
		{
		}

		private bool CanRequestBanner()
		{
			return false;
		}

		public void ShowFull(string location, UnityAction callback = null)
		{
		}

		private void RequestFull()
		{
		}

		private void Interstitial_OnAdDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private bool CanRequestFull()
		{
			return false;
		}

		public bool CanShowFull()
		{
			return false;
		}

		public bool HaveShowFull()
		{
			return false;
		}

		private void OnInterstitialAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnInterstitialLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnInterstitialDismissedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnInterstitialClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnInterstitialFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
		{
		}

		private void WaitLoadFull()
		{
		}

		private void InterstitialFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
		{
		}

		[IteratorStateMachine(typeof(_003CCompleteMethodfull_003Ed__59))]
		private IEnumerator CompleteMethodfull()
		{
			return null;
		}

		private void RequestApplovinAppOpen()
		{
		}

		public void ShowAppOpen(string pos, UnityAction callback = null)
		{
		}

		private void OnAOADisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnAOALoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnAOALoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
		{
		}

		private void OnAOADisplayFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnAOARevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnAOAHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		[IteratorStateMachine(typeof(_003CCompleteMethodAOA_003Ed__73))]
		private IEnumerator CompleteMethodAOA()
		{
			return null;
		}

		public void ShowRewardedVideo(string location, UnityAction<bool> callback)
		{
		}

		public bool IsRewardVideoAvailable()
		{
			return false;
		}

		private bool IsRewardVideoApplovinAvailable()
		{
			return false;
		}

		private void RequestRewardBasedVideo()
		{
		}

		[IteratorStateMachine(typeof(_003CCompleteMethodRewardedVideo_003Ed__85))]
		private IEnumerator CompleteMethodRewardedVideo(bool val)
		{
			return null;
		}

		private bool CanRequestVideo()
		{
			return false;
		}

		private void OnRewardedAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnRewardedAdDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		public void OnRewardedAdDismissedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		public void OnRewardedAdReceivedRewardEvent(string adUnitId, MaxSdkBase.Reward reward, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnRewardedAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		public void OnRewardedAdFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
		{
		}

		private void OnRewardedAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnRewardedAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnApplicationPause(bool pause)
		{
		}

		private void UpdateLastRefocusTime()
		{
		}

		public void ResetShowFullTime()
		{
		}

		public string GetKey()
		{
			return null;
		}

		public bool CanShowAds()
		{
			return false;
		}

		public void RemoveAds()
		{
		}
	}
}
