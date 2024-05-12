using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoneyController : MonoBehaviour
{
    [SerializeField] GameObject moneyPrefab;

    [SerializeField] bool isFillMoney = false;
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
        if (other.CompareTag(Tags.T_BuyZone) && !isFillMoney )
        {
            isFillMoney = true;
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
        if (other.CompareTag(Tags.T_BuyZone) && isFillMoney)
        {
            Debug.Log("Exit");
            isFillMoney = false;
            StopCoroutine(FillMoneyCoroutine(null));
        }
    }

    IEnumerator FillMoneyCoroutine(BuyZone buyZone)
    {
        //Debug.Log("FillMoneyCoroutine");
        while (buyZone.CanBuy && isFillMoney && MoneyManager.Instance.MoneyValue > 0)
        {
            var moneyFill = Instantiate(moneyPrefab);
            moneyFill.transform.position = transform.position;
            moneyFill.transform.DOMove(buyZone.MoneyInput.position, 0.4f).OnComplete(() =>
            {
                if (MoneyManager.Instance.SpendMoney(-1))
                {
                    buyZone.AddMoney(1);
                }
                Destroy(moneyFill);
                if (!buyZone.CanBuy)
                {
                    isFillMoney = false;

                }
            });
          
            yield return new WaitForSeconds(0.2f);

        }
 
    }

}