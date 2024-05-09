using System.Collections.Generic;
using UnityEngine;

public class MoneyProduct : Product
{
	[SerializeField]
	private List<AudioClip> collectSound;

	public override void OnPlayerCollect()
	{
	}

	public override void Init(Vector3 startPosition, Vector3 startRotation)
	{
	}
}
