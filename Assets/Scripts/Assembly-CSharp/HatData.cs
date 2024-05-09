using UnityEngine;

[CreateAssetMenu(fileName = "HatData", menuName = "Data/HatData")]
public class HatData : ItemData
{
	public int Cost;

	public GameObject Model;

	public HatUnlockType UnlockType;
}
