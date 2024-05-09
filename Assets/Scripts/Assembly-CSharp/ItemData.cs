using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "Data/ItemData")]
public class ItemData : ScriptableObject
{
	public string ID;

	public string Name;

	public Sprite Avatar;

	public bool IsUnlocked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}
}
