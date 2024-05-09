using UnityEngine;

public class MoneyContainer : DynamicPositionProductContainer
{
	[SerializeField]
	private int defaultMoney;

	public override void OnPlayerStay(Player player)
	{
	}

	protected override void Load()
	{
	}

	private void Update()
	{
	}
}
