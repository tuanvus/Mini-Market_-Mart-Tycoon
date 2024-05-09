using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UCExtension.GUI
{
	public class BasePopupGUI : BaseGUI
	{
		[SerializeField]
		private List<Button> closeButtons;

		protected override void SetUp()
		{
		}

		public override void Open(object[] initParams, UnityAction finish = null)
		{
		}

		private void OnClickClose()
		{
		}
	}
}
