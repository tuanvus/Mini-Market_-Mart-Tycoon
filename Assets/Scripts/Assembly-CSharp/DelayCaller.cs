using System;
using UnityEngine;

[Serializable]
public class DelayCaller : Caster
{
	[SerializeField]
	private float timeDelay;

	public void SetDelayTime(float time)
	{
	}

	public void SetTimeDelay(float time)
	{
	}

	public override void ResetNextTime()
	{
	}
}
