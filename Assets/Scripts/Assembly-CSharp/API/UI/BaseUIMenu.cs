using UnityEngine;

namespace API.UI
{
	public class BaseUIMenu : BaseUIComp
	{
		public UILayer UILayer;

		[HideInInspector]
		public string UIID;

		public virtual void Init(object[] initParams)
		{
		}

		public virtual void Close()
		{
		}

		public virtual void OnBackClick()
		{
		}
	}
}
