using UnityEngine;

namespace API.IAP
{
	public class BaseIAPManager : MonoBehaviour
	{
		public static BaseIAPManager Ins;

		public bool IsUseIAP;

		public virtual void PurchaseReward(IAPInfo iapPack)
		{
		}
	}
}
