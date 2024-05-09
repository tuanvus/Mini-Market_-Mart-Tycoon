using UnityEngine;
using UnityEngine.UI;

public class RequirementItem : MonoBehaviour
{
	[SerializeField]
	private Text quantityText;

	[SerializeField]
	private Image iconImage;

	public virtual void SetUp(ProductRequirement requirement)
	{
	}
}
