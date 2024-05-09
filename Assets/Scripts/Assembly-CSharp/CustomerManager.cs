using System.Collections.Generic;
using UCExtension.Common;
using UnityEngine;

public class CustomerManager : Service
{
	[SerializeField]
	private float timeDelay;

	[SerializeField]
	private int maxCustomer;

	[SerializeField]
	private List<int> maxCustomerByUsedCoin;

	[SerializeField]
	private List<CustomerBot> customerPrefabs;

	[SerializeField]
	private List<Transform> customerSpawnPositions;

	[SerializeField]
	private List<StoreShelf> storeShelfs;

	[SerializeField]
	private List<Transform> customerHomePositions;

	[SerializeField]
	private DataIdentifier identifier;

	[SerializeField]
	private DelayCaller caller;

	private int numOfCustomer;

	private Dictionary<int, ShelfState> shelfStates;

	private List<CustomerBot> spawnedCustomers;

	private void OnApplicationQuit()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public Transform GetNearestCustomerHomePosition(Transform target)
	{
		return null;
	}

	private void CheckToSpawnCustomer()
	{
	}

	private CustomerBot SpawnCustomer(Vector3 startPosition, List<ProductRequirement> orders)
	{
		return null;
	}

	private void OnCustomerRecyle(CustomerBot customer)
	{
	}

	public List<ProductRequirement> GetNewOrders(List<StoreShelf> availableStores)
	{
		return null;
	}

	private List<StoreShelf> GetAvailableStoreShelf()
	{
		return null;
	}

	private void OnUsedCoinNumChange()
	{
	}

	private int GetMaxCustomerByUsedCoin(int usedCoin)
	{
		return 0;
	}

	private void Load()
	{
	}

	private void Save()
	{
	}
}
