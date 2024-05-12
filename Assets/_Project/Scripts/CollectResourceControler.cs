using System;
using System.Collections;
using System.Collections.Generic;
using PathologicalGames;
using UnityEngine;

public class CollectResourceControler : MonoBehaviour
{
    [SerializeField] int maxResource = 10;
    [SerializeField] int currentResource = 0;
    [SerializeField] private Transform resourceInput;
    [SerializeField] List<GameObject> resourceList;
    [SerializeField] bool isCollect = false;
    [SerializeField] private GameObject txtMax;
    void Start()
    {
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag(Tags.T_Plant))
        {
            if (currentResource < maxResource)
            {
                if (!isCollect)
                {
                    Debug.Log("Collect");
                    var plantBase = other.GetComponent<PlantBase>();
                    if (plantBase.IsCollect)
                    {
                        Debug.Log("Collect !!!!!");
                        isCollect = true;

                        // var plant = plantBase.CollectResource();
                        StartCoroutine(CollectResourceCoroutine(plantBase));
                    }
                }
            }
        }
        else if(other.CompareTag(Tags.T_ShelfGroup))
        {
            if (currentResource > 0)
            {
                StorageHandle storageHandle = other.GetComponent<StorageHandle>();
                if (!storageHandle.IsFull)
                {
                    Debug.Log("Collect Resource");
                    foreach (var resource in resourceList)
                    {
                        storageHandle.AddProduct(resource.transform);
                    }
                    storageHandle.FillFinish();
                    txtMax.SetActive(false);
                    resourceList.Clear();
                    currentResource = 0;
                }
            
            }
            
        }
    }
    


    IEnumerator CollectResourceCoroutine(PlantBase plantBase)
    {
        while (currentResource < maxResource)
        {
            yield return new WaitForSeconds(0.1f);

            if (plantBase.CurrentObj > 0)
            {
                GameObject prefabPlant = plantBase.CollectResource();
                Debug.Log("Collect Resource");
                var plant = PoolManager.Pools[PoolName.resource].Spawn(prefabPlant.transform);
                plant.SetParent(resourceInput);
                plant.localPosition = Vector3.zero + new Vector3(0, currentResource, 0);
                resourceList.Add(plant.gameObject);
                currentResource++;
            }


            if (currentResource >= maxResource)
            {
                txtMax.SetActive(true);
                isCollect = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(Tags.T_Plant))
        {
            isCollect = false;
        }
    }
}