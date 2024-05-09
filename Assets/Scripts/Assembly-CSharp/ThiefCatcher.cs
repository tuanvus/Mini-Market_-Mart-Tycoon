using System;
using UnityEngine;

public class ThiefCatcher : MonoBehaviour
{
	[SerializeField]
	private GameObject net;

	public Action<ThiefBot> OnThiefCaught;

	public void Active(bool isActive)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
