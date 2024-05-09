using System;
using System.Runtime.CompilerServices;

[Serializable]
public class StateMachine<T>
{
	public string CurrentStateName;

	private StateFactory<T> factory;

	public BaseState<T> CurrentState
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public BaseState<T> PrevState
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public StateMachine(T owner)
	{
	}

	public void ChangeState<S>() where S : BaseState<T>
	{
	}

	public bool IsCurrentState<S>() where S : BaseState<T>
	{
		return false;
	}

	public void BackToPrevState()
	{
	}
}
