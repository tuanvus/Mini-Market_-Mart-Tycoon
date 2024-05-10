using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : Singleton<MoneyManager>
{
    public Action<int> OnMoneyValueChanged;
    [SerializeField] int moneyValue = 10;

    public int MoneyValue
    {
        get => moneyValue;
        private set => moneyValue = value;
    }

    void Start()
    {
    }

    public void ChangeMoneyValue(int value)
    {
        moneyValue += value;
        OnMoneyValueChanged?.Invoke(moneyValue);
    }
    
    public bool SpendMoney(int value)
    {
        if (moneyValue >= value)
        {
            moneyValue -= value;
            OnMoneyValueChanged?.Invoke(moneyValue);
            return true;
        }
        return false;
    }
}