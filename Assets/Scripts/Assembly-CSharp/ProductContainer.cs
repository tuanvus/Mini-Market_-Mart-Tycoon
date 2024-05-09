using System.Collections.Generic;
using UnityEngine;

public abstract class ProductContainer : SavableObject, IPlayerStayTrigger, IPlayerEnterTrigger
{
	[SerializeField]
	protected ProductData productData;

	[SerializeField]
	private bool isOutput;

	[SerializeField]
	private bool isInput;

	[SerializeField]
	private TutorialFocus firstPopTutorial;

	[SerializeField]
	private TutorialFocus firstPushTutorial;

	protected Stack<Product> products;

	private float timePlayerEnter;

	public bool CanPopObject => false;

	public ProductData ProductData => null;

	public bool IsOutput => false;

	public bool IsInput => false;

	public int ProductCount => 0;

	protected abstract Vector3 GetGenerateWorldPosition();

	protected abstract Vector3 GetGenerateWorldRotation();

	public abstract bool CanPushProduct();

	public abstract void SetMaxCapcity(int capcity);

	protected virtual void Start()
	{
	}

	public void GenerateObject()
	{
	}

	public void GenerateObject(Transform startPosition)
	{
	}

	public Product PopLastObject()
	{
		return null;
	}

	public List<Product> PopLastObjects(int desireCount)
	{
		return null;
	}

	public void Clear()
	{
	}

	public void Push(Product objectToPush)
	{
	}

	public virtual void OnPlayerStay(Player player)
	{
	}

	protected virtual void Save()
	{
	}

	protected virtual void Load()
	{
	}

	public void OnPlayerEnter(Player player)
	{
	}
}
