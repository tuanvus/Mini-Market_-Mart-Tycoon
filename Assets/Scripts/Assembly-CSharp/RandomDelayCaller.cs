using System;
using UnityEngine;

[Serializable]
public class RandomDelayCaller : Caster
{
	[SerializeField]
	private float timeDelayMin;

	[SerializeField]
	private float timeDelayMax;

	public float TimeDelayMin => 0f;

	public float TimeDelayMax => 0f;

	public override void ResetNextTime()
	{
	}
}
