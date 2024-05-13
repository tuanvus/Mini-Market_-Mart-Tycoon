using System;
using System.Collections;
using System.Collections.Generic;
using PathologicalGames;
using UnityEngine;

public class PaymentHandle : MonoBehaviour
{
    [SerializeField] MoneyItem moneyItem;
    [SerializeField] BoxItem boxItemPrefab;
    [SerializeField] Transform boxPosition;
    [SerializeField] Transform tfMoney;
    [SerializeField] private List<CustomerEntity> customers;
    bool isPayment = false;
    bool canPayment = false;

    void Start()
    {
    }


    public void AddRequestPayment(CustomerEntity customerEntity)
    {
        if (!customers.Contains(customerEntity))
        {
            canPayment = true;
            customers.Add(customerEntity);
        }
    }

    private void OnTriggerStay(Collider other)
    {
       // Debug.Log("Payment = "+other.gameObject.tag +" -- "+other.gameObject.name);
        if (other.gameObject.CompareTag(Tags.T_Player) && !isPayment && canPayment && customers.Count > 0)
        {
            Debug.Log("Payment");
            isPayment = true;
            PaymentHandle payment = other.gameObject.GetComponent<PaymentHandle>();
            StartCoroutine(PaymentCoroutine(payment));
        }
    }

    private IEnumerator PaymentCoroutine(PaymentHandle payment)
    {
        yield return new WaitForSeconds(1f);
        BoxItem boxItem = PoolManager.Pools[PoolName.resource].Spawn(boxItemPrefab.transform).GetComponent<BoxItem>();
        boxItem.transform.SetParent(boxPosition);
        boxItem.transform.localPosition = Vector3.zero;
        CustomerEntity customer = customers[0];
        int countMoney = customer.ResourceList.Count;
        boxItem.AnimateBox(customer);
        this.Wait(0.3f, () =>
        {
            customer.SetBoxItem(boxItem);
            customers.RemoveAt(0);
        });
        this.Wait(1f, () =>
        {
            for (int i = 0; i < countMoney; i++)
            {
                var money = PoolManager.Pools[PoolName.money].Spawn(moneyItem.transform);
                money.SetParent(tfMoney);
                money.localPosition = Vector3.zero;
            }
            
            
            isPayment = false;

        });
        
    }
}