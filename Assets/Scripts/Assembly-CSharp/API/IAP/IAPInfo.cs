using System;
using System.Collections.Generic;

namespace API.IAP
{
	[Serializable]
	public class IAPInfo
	{
		public string name;

		public string packageId;

		public double defaultPrice;

		public string defaultCurrency;

		public List<IAPRewardInfo> rewardInfos;
	}
}
