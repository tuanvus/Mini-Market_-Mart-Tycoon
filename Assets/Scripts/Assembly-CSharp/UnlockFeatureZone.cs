using UnityEngine;

public class UnlockFeatureZone : BuyZone
{
	[SerializeField]
	private LockedFeature lockedFeature;

	public LockedFeature LockedFeature => null;

	protected override void FirstBuy()
	{
	}

	protected override void Buy()
	{
	}

	protected override void Lock()
	{
	}
}
