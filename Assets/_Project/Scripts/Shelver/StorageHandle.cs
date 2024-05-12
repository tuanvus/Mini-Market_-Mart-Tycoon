using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageHandle : MonoBehaviour
{
    [SerializeField] List<Transform> productSlot;
    [SerializeField] int maxProductSlot;
    public int MaxProductSlot => maxProductSlot;
    public int CurrentProductSlot => _slotProductCount;
    public bool IsFull => _slotProductCount >= maxProductSlot;
    
    
    int _slotProductCount = 0;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AddProduct(Transform product)
    {
        product.SetParent(productSlot[_slotProductCount]);
        product.localPosition = Vector3.zero;
        _slotProductCount++;
    }
}