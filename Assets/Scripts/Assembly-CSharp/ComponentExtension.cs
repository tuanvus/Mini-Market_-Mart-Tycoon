using System.Collections.Generic;
using UnityEngine;

public static class ComponentExtension
{
	public static void RemoveComponent<T>(this List<T> list, T item) where T : Component
	{
	}

	public static T PopComponent<T>(this List<T> list, T item) where T : Component
	{
		return null;
	}

	public static T FindComponent<T>(this List<T> list, T item) where T : Component
	{
		return null;
	}

	public static bool ContainComponent<T>(this List<T> list, T item) where T : Component
	{
		return false;
	}

	public static void AddUniqueComponent<T>(this List<T> list, T item) where T : Component
	{
	}
}
