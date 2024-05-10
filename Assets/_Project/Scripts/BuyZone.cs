using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuyZone : MonoBehaviour
{
    public Action OnSuccessfulBuy;
    [SerializeField] int itemCost = 10;
    [SerializeField] int currentMoney = 0;
    [SerializeField] private Transform moneyInput;
    [SerializeField] TextMeshPro moneyText;

    public bool CanBuy => _canBuy;
    public Transform MoneyInput => moneyInput;

    bool _canBuy = false;

    void Start()
    {
        _canBuy = true;
        moneyText.text = (itemCost - currentMoney).ToString();
    }

    public void AddMoney(int value)
    {
        moneyText.text = (itemCost - currentMoney).ToString();
        currentMoney += value;
        if (currentMoney >= itemCost)
        {
            _canBuy = false;
            currentMoney -= itemCost;
            OnSuccessfulBuy?.Invoke();
        }
    }
}