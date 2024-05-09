using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

public class Car : MonoBehaviour
{
	[SerializeField]
	private Transform comingPos;

	[SerializeField]
	private Transform stayingPos;

	[SerializeField]
	private Transform leavePos;

	[SerializeField]
	private float timeMoveCar;

	private Tween moveTween;

	public bool IsMoving
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void Hide()
	{
	}

	public virtual void Come(bool instantly, UnityAction finish = null)
	{
	}

	public virtual void Leave(UnityAction finish = null)
	{
	}
}
