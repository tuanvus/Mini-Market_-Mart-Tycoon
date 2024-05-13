using System.Collections;
using System.Collections.Generic;
using PathologicalGames;
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
            ShelverEntity payment = ShelverManager.Instance.GetShelverPayment();

            var customer = PoolManager.Pools[PoolName.resource].Spawn(customerPrefab.transform, spawnPoints[Random.Range(0, spawnPoints.Count)].position, Quaternion.identity).GetComponent<CustomerEntity>();
            customer.MoveToTarget(shelver.GetPositionSlotCustomer(), shelver.transform);
            customer.SetPosExit(spawnPoints[0], spawnPoints[0]);
            customer.SetPosPayment(payment.GetPositionSlotCustomer(), payment.transform);
            shelver.AddCustomer(customer);
            customer.OnMoveEnd += MoveEnd;
            customerEntities.Add(customer);
            currentCustomer++;
        }
    }

    private void MoveEnd(CustomerEntity obj)
    {
        currentCustomer--;
        customerEntities.Remove(obj);
        PoolManager.Pools[PoolName.resource].Despawn(obj.transform);
        this.Wait(0.4f, () =>
        {
            SpawnCustomer();
        });
    }
}