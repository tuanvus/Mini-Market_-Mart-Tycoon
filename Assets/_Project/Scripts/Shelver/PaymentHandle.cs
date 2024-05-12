using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaymentHandle : MonoBehaviour
{
    [SerializeField] private List<CustomerEntity> customers;
    void Start()
    {
        
    }

   

    public void AddRequestPayment(CustomerEntity customerEntity)
    {
        if (!customers.Contains(customerEntity))
        {
            customers.Add(customerEntity);
        }
    }
}
