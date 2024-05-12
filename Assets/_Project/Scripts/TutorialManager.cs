using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    [SerializeField] List<ItemBuilding> itemBuildings;
    [SerializeField] int step = 0;

    void Start()
    {
        foreach (var item in itemBuildings)
        {
            item.OnUnlockItem += OnCheckStep;
            item.gameObject.SetActive(false);
        }
        itemBuildings[step].gameObject.SetActive(true);
    }

    private void OnCheckStep()
    {
        step++;
        itemBuildings[step].gameObject.SetActive(true);
        if (step >= 2 )
        {
            CustomerManager.Instance.SpawnCustomer();
        }
    }
}