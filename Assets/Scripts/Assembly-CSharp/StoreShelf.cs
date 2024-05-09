using System.Collections.Generic;
using UnityEngine;

public class StoreShelf : MonoBehaviour
{
	[SerializeField]
	protected List<Transform> queuePositions;

	private List<CustomerSlot> customerSlots;

	[SerializeField]
	private ProductContainer container;

	public int QueueCount => 0;

	public ProductContainer Container => null;

	private void SetUpCustomerSlots()
	{
	}

	public Transform Enqueue(CustomerBot customer)
	{
		return null;
	}

	public void Dequeue(CustomerBot customer)
	{
	}

	public void GetPositions()
	{
	}
}
