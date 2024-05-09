using DG.Tweening;
using UCExtension.GUI.Animation;
using UnityEngine;
using UnityEngine.Events;

public class SlideAnim : GUIAnim
{
	[SerializeField]
	private SlideAnimDirection openDirection;

	[SerializeField]
	private SlideAnimDirection closeDirection;

	[SerializeField]
	private Ease openEase;

	[SerializeField]
	private Ease closeEase;

	[SerializeField]
	private RectTransform rootMotion;

	[SerializeField]
	private float timeMove;

	private Vector3 rootAnchorPosition;

	private void Awake()
	{
	}

	public override void Open(UnityAction finish = null)
	{
	}

	public override void Close(UnityAction finish = null)
	{
	}

	public Vector2 GetPosition(SlideAnimDirection direction)
	{
		return default(Vector2);
	}
}
