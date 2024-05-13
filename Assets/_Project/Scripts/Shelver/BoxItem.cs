using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
using PathologicalGames;
using UnityEngine;

public class BoxItem : MonoBehaviour
{
    [SerializeField] private Animator Animator;
    [SerializeField, AnimatorName] string closeAnimation;
    [SerializeField] List<Transform> slotProduct;

    void Start()
    {
    }

    public void AnimateBox(CustomerEntity customer)
    {
        for (int i = 0; i < customer.ResourceList.Count; i++)
        {
            var item = customer.ResourceList[i];
            item.transform.SetParent(slotProduct[i]);
            item.transform.localPosition = Vector3.zero;
            PoolManager.Pools[PoolName.resource].Despawn(item.transform);
        }

        customer.ClearResource();

        Animator.CrossFadeInFixedTime(closeAnimation, 0.1f);
    }
}