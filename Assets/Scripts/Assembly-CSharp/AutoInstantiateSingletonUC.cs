using UnityEngine;

public class AutoInstantiateSingletonUC<T> : MonoBehaviour where T : AutoInstantiateSingletonUC<T>
{
	private static T instance;

	public static T Instance => null;

	private void OnDestroy()
	{
	}

	protected virtual void SetUp()
	{
	}
}
