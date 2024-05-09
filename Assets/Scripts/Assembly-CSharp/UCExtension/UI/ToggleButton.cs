using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UCExtension.UI
{
	public class ToggleButton : MonoBehaviour
	{
		[SerializeField]
		private Image mainImage;

		[SerializeField]
		private Text titleText;

		[SerializeField]
		private ToggleButtonSetting activeSettings;

		[SerializeField]
		private ToggleButtonSetting disableSettings;

		private Button button;

		private bool isActive;

		public Action<bool> OnToggle;

		public static UnityAction<string, bool> OnToggleCallback;

		private void Start()
		{
		}

		public void SetUp(bool isAtive)
		{
		}

		private void OnClick()
		{
		}

		private void ResetApearance()
		{
		}
	}
}
