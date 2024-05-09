using System.Collections.Generic;

public class StateFactory<T>
{
	private T owner;

	private Dictionary<string, BaseState<T>> states;

	public BaseState<T> GetState<S>() where S : BaseState<T>
	{
		return null;
	}

	public StateFactory(T target)
	{
	}
}
