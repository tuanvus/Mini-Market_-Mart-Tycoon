using System.Collections.Generic;
using UCExtension.Common;
using UnityEngine;

namespace UCExtension.GUI
{
	public class GUIController : Singleton<GUIController>
	{
		[Header("GUI OBjects")]
		private Dictionary<string, BaseGUI> listGuis;

		private Camera mainCamera;

		private string UIPath;

		protected override void SetUp()
		{
		}

		public void OnChangeScene()
		{
		}

		public void HideAllGUI()
		{
		}

		public BaseGUI GetGUI(string guiName)
		{
			return null;
		}

		public void ShowGUI(string guiName, object[] pars)
		{
		}

		public void ShowGUI(string guiName)
		{
		}

		public void HideGUI(string guiName)
		{
		}

		public GUIController()
		{
			((Singleton<>)(object)this)._002Ector();
		}
	}
}
