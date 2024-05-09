using UnityEngine;
using UnityEngine.UI;

public class FpsLogger : MonoBehaviour
{
	[SerializeField]
	private bool showFps;

	[SerializeField]
	private Text fpsText;

	[SerializeField]
	private Color goodFpsColor;

	[SerializeField]
	private Color badFpsColor;

	[SerializeField]
	private int goodFps;

	private int fpsCount;

	private float nextTime;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
