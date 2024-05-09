using UnityEngine;
using dynamicscroll;

public class ExampleScroll : MonoBehaviour
{
	public DynamicScrollRect verticalScroll;

	public GameObject referenceObject;

	private DynamicScroll<ExampleData, ExampleDynamicObject> mVerticalDynamicScroll;

	public void Start()
	{
	}
}
