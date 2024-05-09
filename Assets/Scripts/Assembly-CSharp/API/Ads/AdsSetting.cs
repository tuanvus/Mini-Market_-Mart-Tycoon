using System;

namespace API.Ads
{
	[Serializable]
	public class AdsSetting
	{
		public bool IsUseApplovin;

		public string SDK_KEY_APPLOVIN;

		public string BANNER_ID_APPLOVIN;

		public string FULL_REWARD_ID_APPLOVIN;

		public string FULL_ID_APPLOVIN;

		public string REWARD_ID_APPLOVIN;

		public string AOA_ID_APPLOVIN;

		public bool IsUseAppOpenAd;

		public bool IsShowBanner;

		public bool IsBannerInStart;

		public MaxSdkBase.BannerPosition BannerPosition;

		public BannerColor BannerColor;

		public int MaxClickBanner;

		public int TimeBetweenRefocusShow;

		public int TimeBetweenShowFull;

		public int MaxClickFull;

		public int MaxClickVideo;

		public bool IsRefocusShowAds;
	}
}
