using UnityEngine;

[CreateAssetMenu(fileName = "ProductData", menuName = "MiniMart/ProductData")]
public class ProductData : ScriptableObject
{
	public int ID;

	public int Price;

	public Sprite Avatar;

	public Product Prefab;

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

	public Product GenerateObject(Transform parent)
	{
		return null;
	}
}
