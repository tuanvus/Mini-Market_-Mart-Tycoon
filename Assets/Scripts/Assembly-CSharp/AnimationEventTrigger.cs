using System;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventTrigger : MonoBehaviour
{
	private Dictionary<string, Action> events;

	public void ClearEvents()
	{
	}

	public void RegisterEvent(string eventName, Action callback)
	{
	}

	public void UnregisterEvent(string eventName, Action callback)
	{
	}

	public void PatchEvent(string eventName)
	{
	}
}
