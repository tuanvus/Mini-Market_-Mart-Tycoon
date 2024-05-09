using UnityEngine;

namespace UCExtension.UI
{
	[RequireComponent(typeof(ToggleButton))]
	public abstract class SettingToggle : MonoBehaviour
	{
		private ToggleButton toggle;

		protected abstract bool StartState { get; }

		protected abstract void OnToggle(bool value);

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}
	}
}
