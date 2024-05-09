using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
	private Animator animator;

	private AnimationEventTrigger eventTrigger;

	private CharacterAnimState currentState;

	private int stateKeyHash;

	private int carryStateKeyHash;

	private int onChangeStateKeyHash;

	private float attackSpeed;

	private void Awake()
	{
	}

	public void SetAttackSpeed(float speed)
	{
	}

	public void ChangeAnimation(CharacterAnimState state)
	{
	}

	public void ChangeCarryingState(CarryingState carryingState)
	{
	}
}
