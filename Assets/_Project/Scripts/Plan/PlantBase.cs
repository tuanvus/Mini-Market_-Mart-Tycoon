using System;
using System.Collections;
using System.Collections.Generic;
using PathologicalGames;
using UnityEngine;

public class PlantBase : MonoBehaviour
{
    [SerializeField] private int maxObjl;
    [SerializeField] private int currentObj;
    [SerializeField] List<Transform> slots;
    [SerializeField] private GameObject objViewPrefab;
    [SerializeField] List<GameObject> objList;
    private bool isCollect = false;

    public bool IsCollect => isCollect;
    public int CurrentObj => currentObj;
    bool isSpawn = false;
    void Start()
    {
    }

    private void OnEnable()
    {
        isCollect = false;
        objList = new List<GameObject>();
        isSpawn = true;
        StartCoroutine(SpawnObj());
    }

  

    IEnumerator SpawnObj()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);

            if (currentObj < maxObjl && isSpawn)
            {
                yield return new WaitForSeconds(1f);
                // Debug.Log("Spawn ");
                isCollect = true;

                var obj =  PoolManager.Pools[PoolName.resource].Spawn(objViewPrefab, slots[currentObj].position, Quaternion.identity, slots[currentObj]);
                obj.transform.localPosition = Vector3.zero;
                objList.Add(obj.gameObject);
                currentObj++;

                if (currentObj >= maxObjl)
                {
                    // Debug.Log("Stop Spawn");
                    yield return null;
                }
            }

            if (!isSpawn)
            {
                yield return new WaitForSeconds(0.5f);
                isSpawn = true;
            }
        }
      
    }

    public GameObject CollectResource()
    {

        PoolManager.Pools[PoolName.resource].Despawn(objList[currentObj - 1].transform);
        objList.Remove(objList[currentObj - 1] );

        currentObj--;
        
        isSpawn = false;
        return objViewPrefab;
    }
}