using System.Runtime.CompilerServices;
using UnityEngine;

public class Product : MovingObject
{
	[SerializeField]
	public ProductData CurrentData
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public Product SetData(ProductData data)
	{
		return null;
	}

	public virtual void Init(Vector3 startPosition, Vector3 startRotation)
	{
	}

	public virtual void OnPlayerCollect()
	{
	}
}
