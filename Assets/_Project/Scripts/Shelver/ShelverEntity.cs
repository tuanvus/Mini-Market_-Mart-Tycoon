using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelverEntity : ItemBuilding
{
    [SerializeField] List<Transform> slotCustomer;
    [SerializeField] StorageHandle storageHandle;

    [SerializeField] PaymentHandle paymentHandle;
    [SerializeField] private bool foodCounter;
    public bool IsFull
    {
        get
        {
            return storageHandle.IsFull;
        }
    }

    public bool FoodCounter => foodCounter;


    int _slotCustomerCount = 0;

    void Start()
    {
    }
    public void AddRequestPayment(CustomerEntity customerEntity)
    {
        paymentHandle.AddRequestPayment(customerEntity);
    }
  

    public void AddProduct(Transform product)
    {
        storageHandle.AddProduct(product);
    }

    public Transform GetPositionSlotCustomer()
    {
        return slotCustomer[_slotCustomerCount];
    }

    public void AddCustomer(CustomerEntity customer)
    {
        // customer.SetParent(slotCustomer[_slotCustomerCount]);
        // customer.localPosition = Vector3.zero;
        _slotCustomerCount++;
    }
}