using UnityEngine;
using dynamicscroll;

public class SelectLevelPanel : MonoBehaviour
{
	public DynamicScrollRect verticalScroll;

	public GameObject referenceObject;

	private DynamicScroll<ListSelectLevelItemData, SelectLevelItemRow> mVerticalDynamicScroll;

	public void Start()
	{
	}
}
