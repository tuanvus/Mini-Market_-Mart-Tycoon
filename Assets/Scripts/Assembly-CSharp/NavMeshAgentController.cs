using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

[RequireComponent(typeof(NavMeshAgent))]
public class NavMeshAgentController : MonoBehaviour
{
	protected NavMeshAgent navMeshAgent;

	private float originalAngularSpeed;

	public bool IsMoving => false;

	private void Awake()
	{
	}

	public void Active(bool isActive)
	{
	}

	public void StopMove()
	{
	}

	public void KnockBack(Transform agent, float range, UnityAction finish = null)
	{
	}

	private Vector3 GetKnockBackPosition(Vector3 direction, float range)
	{
		return default(Vector3);
	}
}
