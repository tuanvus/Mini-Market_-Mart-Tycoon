using UCExtension.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(EventTrigger))]
public class PropogateDrag : MonoBehaviour
{
	public ScrollRect horizontalScrollView;

	public ScrollSnapRect scrollSnapRect;

	public ScrollRect verticalScrollView;

	private bool isDragHorizontal;

	private void Start()
	{
	}

	private void RegisterEvent()
	{
	}

	private void OnBeginDrag(BaseEventData data)
	{
	}

	private void OnDrag(BaseEventData data)
	{
	}

	private void OnEndDrag(BaseEventData data)
	{
	}

	private void OnInitializePotentialDrag(BaseEventData data)
	{
	}

	private void OnScroll(BaseEventData data)
	{
	}

	private void OnPointerDown(BaseEventData data)
	{
	}

	public void SetVerticalScroll(ScrollRect horizontalScroll)
	{
	}

	public void SetHorizontalScroll(ScrollRect horizontalScroll)
	{
	}
}
