using UnityEngine;

public abstract class Upgrader : MonoBehaviour
{
	[SerializeField]
	private UpgradeData upgradeData;

	[SerializeField]
	private GameObject effect;

	[SerializeField]
	private Transform upgradeCFT;

	public abstract void SetUpgradeLevel(int level);

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void OnUpgrade(UpgradeData data)
	{
	}
}
