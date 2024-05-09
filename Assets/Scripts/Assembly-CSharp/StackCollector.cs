using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class StackCollector : MonoBehaviour
{
	[SerializeField]
	protected Transform maxObject;

	[SerializeField]
	protected bool canVibrate;

	[SerializeField]
	private float timeCollect;

	[SerializeField]
	private float collectJumpForce;

	[SerializeField]
	private bool alwayInCarryingState;

	[SerializeField]
	private List<AudioClip> collectSounds;

	[SerializeField]
	private List<AudioClip> popSounds;

	protected List<Product> collectedObjects;

	public Action OnCollectObject;

	public Action OnEmptyObject;

	private Dictionary<int, int> collectedIDs;

	public bool IsAlwayInCarryingState => false;

	public Dictionary<int, int> CollectedIDs => null;

	public bool HasProduct => false;

	public abstract bool CanCollect { get; }

	public bool IsEmpty => false;

	protected abstract Vector3 GetLocalPushPosition();

	protected abstract Vector3 GetMaxPosition();

	protected abstract void ReorderObjects();

	private void Start()
	{
	}

	public virtual void Collect(Product objectToCollect)
	{
	}

	public Product Pop(int id)
	{
		return null;
	}

	public List<Product> PopAll()
	{
		return null;
	}

	public Product PopLast()
	{
		return null;
	}

	public void Clear()
	{
	}

	private void Vibrate()
	{
	}

	private void AddToCollectedID(int ID)
	{
	}

	private void RemoveFromCollectedID(int ID)
	{
	}

	private void CheckCollectedObjectSize()
	{
	}

	public virtual void SetUpgradeLevel(int level)
	{
	}
}
