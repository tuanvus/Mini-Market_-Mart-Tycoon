using System;
using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
using PathologicalGames;
using UnityEngine;
using UnityEngine.AI;

public class CustomerEntity : MonoBehaviour
{
    public Action<CustomerEntity> OnMoveEnd;
    [SerializeField] AnimatorHandle animatorHandle;
    [SerializeField] private NavMeshAgent agent;
    [SerializeField, AnimatorParam] private string walkAnimation;

    [Header("--------------------------")] [SerializeField]
    int maxResource = 10;

    [SerializeField] int currentResource = 0;
    [SerializeField] private Transform resourceInput;
    [SerializeField] List<GameObject> resourceList;
    public List<GameObject> ResourceList
    {
       private set { resourceList = value; }
        get { return resourceList; }
    }
    BoxItem boxItem;
    private Transform posPayment;
    private Transform posExit;
    private Transform parentPayment;
    private Transform parentExit;

    bool canPayment = false;

    bool isMove = false;
    private bool moveEnd = false;

    void Start()
    {
       
        //isMove = false;
    }

    private void OnEnable()
    {
        canPayment = false;
        moveEnd = false;
    }

    public void ClearResource()
    {
       
        resourceList.Clear();
        currentResource = 0;
    }

    public void SetPosPayment(Transform pos, Transform parentPayment)
    {
        posPayment = pos;
        this.parentPayment = parentPayment;
    }

    public void SetPosExit(Transform pos, Transform parentExit)
    {
        posExit = pos;
        this.parentExit = parentExit;
    }

    public void MoveToTarget(Transform target, Transform parentShelver)
    {
        agent.SetDestination(target.position);
        isMove = true;
        animatorHandle.Playanimation(walkAnimation, 1);
        StartCoroutine(WaitForDestinationReached(parentShelver));
    }

    IEnumerator WaitForDestinationReached(Transform parentShelver)
    {
        while (isMove)
        {
            if (!agent.pathPending && agent.remainingDistance <= agent.stoppingDistance)
            {
                // Agent đã đến đích
                transform.LookAt(parentShelver);
                animatorHandle.Playanimation(walkAnimation, 0);
                if (moveEnd)
                {
                    if ( this.boxItem != null)
                    {
                        PoolManager.Pools[PoolName.resource].Despawn(this.boxItem.transform);
                    }

                    currentResource = 0;
                    moveEnd = false;
                    OnMoveEnd?.Invoke(this);
                }
                
                yield break;
            }

            yield return null;
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag(Tags.T_ShelfGroup))
        {
            StorageHandle storageHandle = other.GetComponent<StorageHandle>();
            if (storageHandle.CurrentProductSlot > 0 && storageHandle.IsCollect )
            {
                int tempReq = maxResource - currentResource;
                int temp = storageHandle.CurrentProductSlot - tempReq;
                Debug.Log("Temp: " + temp);
                int valueSpend = temp < 0 ? storageHandle.CurrentProductSlot : tempReq;
                currentResource += valueSpend;

                storageHandle.SpendProduct(valueSpend);
                var obj = storageHandle.GetProduct();
                if (resourceList.Count < maxResource)
                {
                    int y = resourceList.Count;

                    for (int i = 0; i < valueSpend; i++)
                    {
                        var o = PoolManager.Pools[PoolName.resource].Spawn(obj);
                        o.SetParent(resourceInput);
                        o.localPosition = Vector3.zero + new Vector3(0, y+i, 0);
                        resourceList.Add(o.gameObject);
                    }
                }
            


                if (currentResource >= maxResource && !canPayment)
                {
                    canPayment = true;
                    MoveToTarget(posPayment, parentPayment);
                    parentPayment.GetComponent<ShelverEntity>().AddRequestPayment(this);
                }
            }
        }
    }

    public void SetBoxItem(BoxItem boxItem)
    {
        this.boxItem = boxItem;
        boxItem.transform.SetParent(resourceInput);
        boxItem.transform.localPosition = Vector3.zero;
        moveEnd = true;
        MoveToTarget(posExit, parentExit);
    }
}