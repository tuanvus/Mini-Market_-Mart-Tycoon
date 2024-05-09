using UnityEngine;

public class AutoSizeCamera : MonoBehaviour
{
	[SerializeField]
	private Camera mainCamera;

	[SerializeField]
	private Vector2 defaultScreen;

	[SerializeField]
	private AutoSizeMatchType matchType;

	[Range(0f, 1f)]
	[SerializeField]
	private float matchRatio;

	private float defaultOrthoSize;

	private float defaultFieldOfView;

	private void Awake()
	{
	}

	public void UpdateSize()
	{
	}

	public float GetRatio(AutoSizeMatchType matchType)
	{
		return 0f;
	}

	private float GetDefaultRatio(AutoSizeMatchType matchType)
	{
		return 0f;
	}

	private float GetCurrentRatio(AutoSizeMatchType matchType)
	{
		return 0f;
	}
}
