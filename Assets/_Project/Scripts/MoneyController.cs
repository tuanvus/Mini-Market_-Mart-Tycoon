using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoneyController : MonoBehaviour
{
    [SerializeField] GameObject moneyPrefab;

    bool _isFillMoney = false;
    void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Tags.T_Money))
        {
            MoneyItem moneyItem = other.GetComponent<MoneyItem>();
            MoneyManager.Instance.ChangeMoneyValue(moneyItem.MoneyValue);
            Destroy(other.gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag(Tags.T_BuyZone) && !_isFillMoney )
        {
            _isFillMoney = true;
            BuyZone buyZone = other.GetComponent<BuyZone>();
            if (buyZone.CanBuy)
            {
                Debug.Log("BuyZone");

               StartCoroutine(FillMoneyCoroutine(buyZone));
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(Tags.T_BuyZone) && _isFillMoney)
        {
            Debug.Log("Exit");
            _isFillMoney = false;
            StopCoroutine(FillMoneyCoroutine(null));
        }
    }

    IEnumerator FillMoneyCoroutine(BuyZone buyZone)
    {
        Debug.Log("FillMoneyCoroutine");
        while (buyZone.CanBuy && _isFillMoney && MoneyManager.Instance.MoneyValue > 0)
        {
            var moneyFill = Instantiate(moneyPrefab);
            moneyFill.transform.position = transform.position;
            moneyFill.transform.DOMove(buyZone.MoneyInput.position, 1f).OnComplete(() =>
            {
                buyZone.AddMoney(1);
                MoneyManager.Instance.ChangeMoneyValue(-1);
                Destroy(moneyFill);
            });
            yield return new WaitForSeconds(0.5f);

        }
 
    }

}