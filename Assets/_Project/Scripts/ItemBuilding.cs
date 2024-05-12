using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class ItemBuilding : MonoBehaviour
{
    public Action OnUnlockItem;
    [SerializeField] private GameObject model;
    [SerializeField] BuyZone buyZone;
    bool _isUnlocked = false;

    public bool IsUnlocked => _isUnlocked;

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
        OnUnlockItem?.Invoke();
        _isUnlocked = true;
    }

    void Start()
    {
    }
}