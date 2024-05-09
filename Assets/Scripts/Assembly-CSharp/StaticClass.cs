public class StaticClass
{
	public static readonly string USE_APPLOVIN_ADS;

	public static readonly string USE_FIREBASE_ANA;

	public static readonly string USE_AOA;

	public static readonly string USE_FIREBASE_REMOTE;

	public static readonly string USE_FACEBOOK;

	public static readonly string USE_ADJUST;

	public static readonly string USE_IAP;

	public static readonly string REMOVE_ADS;

	public static readonly string RATE;

	public static readonly string ADS_SETTING;

	public static readonly string ALARM_SETTING;

	public static readonly string MORE_GAME;

	public static string MoreGameLink
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static bool IsAndroid()
	{
		return false;
	}

	public static bool IsIOS()
	{
		return false;
	}

	public static DeviceType GetCurDeviceType()
	{
		return default(DeviceType);
	}

	public static void RateApp()
	{
	}

	public void ShareApp()
	{
	}

	public static void MoreGame()
	{
	}
}
