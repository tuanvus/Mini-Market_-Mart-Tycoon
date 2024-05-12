using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerManager : Singleton<CustomerManager>
{
    [SerializeField] private List<CustomerEntity> customerEntities;
    [SerializeField] List<Transform> spawnPoints;
    [SerializeField] private float timeSpawn = 5f;
    [SerializeField] CustomerEntity customerPrefab;
    [SerializeField] int maxCustomer = 5;
    [SerializeField] int currentCustomer = 0;

    void Start()
    {
    }

    public void SpawnCustomer()
    {
        StartCoroutine(SpawnCustomerRoutine());
    }

    IEnumerator SpawnCustomerRoutine()
    {
        while (currentCustomer < maxCustomer)
        {
            yield return new WaitForSeconds(timeSpawn);

            ShelverEntity shelver = ShelverManager.Instance.GetShelverFood();
            var customer = Instantiate(customerPrefab, spawnPoints[Random.Range(0, spawnPoints.Count)].position, Quaternion.identity).GetComponent<CustomerEntity>();
            customer.MoveToShelverTarget(shelver.GetPositionSlotCustomer());
            shelver.AddCustomer(customer);
            customerEntities.Add(customer);
            currentCustomer++;
        }
    }
}