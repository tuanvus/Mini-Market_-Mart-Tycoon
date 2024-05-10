using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class ItemBuilding : MonoBehaviour
{
    [SerializeField] private GameObject model;
    [SerializeField] BuyZone buyZone;

    private void Awake()
    {
        buyZone.OnSuccessfulBuy += BuildItem;
    }

    private void BuildItem()
    {
        buyZone.gameObject.SetActive(false);
        model.transform.localScale = Vector3.zero;
        model.SetActive(true);
        model.transform.DOScale(1, 0.5f);
    }

    void Start()
    {
        
    }

}
