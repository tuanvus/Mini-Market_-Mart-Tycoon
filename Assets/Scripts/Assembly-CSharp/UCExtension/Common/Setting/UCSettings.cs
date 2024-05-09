using System;

namespace UCExtension.Common.Setting
{
	public static class UCSettings
	{
		public static Action<bool> OnChangeVibrateSettingCallback;

		public static bool CanVibrate
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
