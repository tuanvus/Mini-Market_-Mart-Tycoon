using System.Collections;
using System.Collections.Generic;
using PathologicalGames;
using UnityEngine;

public class StorageHandle : MonoBehaviour
{
    [SerializeField] List<Transform> productSlot;
    [SerializeField] int maxProductSlot;
    public int MaxProductSlot => maxProductSlot;
    public int CurrentProductSlot => _slotProductCount;
    public bool IsFull => _slotProductCount >= maxProductSlot;
    [SerializeField] GameObject prefabProduct;
    [SerializeField] List<Transform> productList;

    [SerializeField] int _slotProductCount = 0;

    
    bool isCollect = false;
    public bool IsCollect => isCollect;
    void Start()
    {
        isCollect = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public GameObject GetProduct()
    {
        return prefabProduct;
    }

    public void AddProduct(Transform product)
    {
        product.SetParent(productSlot[_slotProductCount]);
        product.localPosition = Vector3.zero;
        _slotProductCount++;
        productList.Add(product);
    }

    public void SpendProduct(int value)
    {
        Debug.Log("Spend Product " + _slotProductCount +" -- "+value);

        _slotProductCount -= value;
        if (_slotProductCount < 0)
        {
            _slotProductCount = 0;
            isCollect = false;
        }

        for (int i = productList.Count - 1; i >= _slotProductCount; i--)
        {
            PoolManager.Pools[PoolName.resource].Despawn(productList[i]);
            productList.RemoveAt(i);
        }
    }

    public void FillFinish()
    {
        this.Wait(0.7f, () =>
        {
            isCollect = true;
        });
    }
    
}