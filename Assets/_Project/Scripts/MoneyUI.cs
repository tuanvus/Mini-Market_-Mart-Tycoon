using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyUI : MonoBehaviour
{
    [SerializeField] Text moneyText;

    private void Awake()
    {
        MoneyManager.Instance.OnMoneyValueChanged += UpdateMoneyText;
    }
    

    private void UpdateMoneyText(int obj)
    {
        moneyText.text = obj.ToString();
    }

    void Start()
    {
        moneyText.text  = MoneyManager.Instance.MoneyValue.ToString();
    }
}