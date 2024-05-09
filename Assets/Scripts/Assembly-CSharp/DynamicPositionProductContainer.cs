using UnityEngine;

public class DynamicPositionProductContainer : ProductContainer
{
	[Header("Dynamic position container")]
	[SerializeField]
	private float distanceX;

	[SerializeField]
	private float distanceY;

	[SerializeField]
	private float distanceZ;

	[SerializeField]
	private int rowCount;

	[SerializeField]
	private int colCount;

	public override bool CanPushProduct()
	{
		return false;
	}

	public override void SetMaxCapcity(int capcity)
	{
	}

	protected override Vector3 GetGenerateWorldPosition()
	{
		return default(Vector3);
	}

	protected override Vector3 GetGenerateWorldRotation()
	{
		return default(Vector3);
	}
}
