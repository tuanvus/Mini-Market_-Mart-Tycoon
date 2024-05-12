using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelverManager : Singleton<ShelverManager>
{
    [SerializeField] private List<ShelverEntity> shelverList;
    
    void Start()
    {
        
    }

   public ShelverEntity GetShelverFood()
    {
        Debug.Log("GetShelverFood = "+ shelverList.Count);
        foreach (var shelver in shelverList)
        {
            if (!shelver.IsFull && shelver.IsUnlocked && shelver.FoodCounter)
            {
                return shelver;
            }
        }

        return null;
    }
}
