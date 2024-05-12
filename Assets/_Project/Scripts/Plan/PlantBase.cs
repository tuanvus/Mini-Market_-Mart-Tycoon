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
    void Start()
    {
    }

    private void OnEnable()
    {
        isCollect = false;
        objList = new List<GameObject>();
        StartCoroutine(SpawnObj());
    }

  

    IEnumerator SpawnObj()
    {
        yield return new WaitForSeconds(0.6f);
        while (currentObj < maxObjl )
        {
            yield return new WaitForSeconds(1);
           // Debug.Log("Spawn ");
            isCollect = true;

            var obj = Instantiate(objViewPrefab, slots[currentObj].position, Quaternion.identity, slots[currentObj]);
            obj.transform.localPosition = Vector3.zero;
            objList.Add(obj);
            currentObj++;

            if (currentObj >= maxObjl)
            {
               // Debug.Log("Stop Spawn");
                yield return null;
            }
        }
    }

    public GameObject CollectResource()
    {

        PoolManager.Pools[PoolName.resource].Despawn(objList[currentObj - 1].transform);
        objList.Remove(objList[currentObj - 1] );

        currentObj--;
        
        return objViewPrefab;
    }
}