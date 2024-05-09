using System.Collections.Generic;
using UnityEngine;

namespace API.UI
{
	public class CanvasManager : MonoBehaviour
	{
		public static CanvasManager Ins;

		public bool dontDestroyOnLoad;

		private Dictionary<string, BaseUIMenu> LoadedUI;

		private List<List<BaseUIMenu>> OpenedUI;

		private List<Transform> UILayerParents;

		private string UIPath;

		private void Awake()
		{
		}

		private void SetStretchAll(RectTransform rect)
		{
		}

		public void OpenUI(string name, object[] initParams, int overrideChildIndex = 99)
		{
		}

		public void CloseUI(BaseUIMenu ui)
		{
		}

		public void CloseUI(string name)
		{
		}

		public void Init(string firstOpenUI, object[] initParams, string uiDataPath = "UI/")
		{
		}
	}
}
