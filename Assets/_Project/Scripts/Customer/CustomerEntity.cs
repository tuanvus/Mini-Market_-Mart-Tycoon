using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.AI;

public class CustomerEntity : MonoBehaviour
{
    [SerializeField] AnimatorHandle animatorHandle;
    [SerializeField] private NavMeshAgent agent;
    [SerializeField,AnimatorParam] private string walkAnimation;
    bool isMove = false;
    void Start()
    {
        
    }

 

    public void MoveToShelverTarget(Transform target)
    {
        agent.SetDestination(target.position);
        isMove = true;
        animatorHandle.Playanimation(walkAnimation,1);
        StartCoroutine(WaitForDestinationReached());
    }
    
    IEnumerator WaitForDestinationReached()
    {
        while (isMove)
        {
            if (!agent.pathPending && agent.remainingDistance <= agent.stoppingDistance)
            {
                // Agent đã đến đích
                animatorHandle.Playanimation(walkAnimation,0);
                yield break;
            }

            yield return null;
        }
    }
}