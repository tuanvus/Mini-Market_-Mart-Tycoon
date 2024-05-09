using UnityEngine;
using UnityEngine.Events;

public abstract class SingleAnimation : MonoBehaviour
{
	public abstract void Play(UnityAction finish = null);
}
