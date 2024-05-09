public class BaseState<T>
{
	protected T owner;

	protected StateMachine<T> stateMachine;

	public virtual void SetOwner(T target)
	{
	}

	public virtual void Enter()
	{
	}

	public virtual void HandleInput()
	{
	}

	public virtual void LogicUpdate()
	{
	}

	public virtual void PhysicsUpdate()
	{
	}

	public virtual void Exit()
	{
	}
}
