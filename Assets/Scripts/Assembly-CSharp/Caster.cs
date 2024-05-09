using System;

[Serializable]
public class Caster
{
	protected float nextTime;

	public bool CanCall => false;

	public bool Call()
	{
		return false;
	}

	public virtual void ResetNextTime()
	{
	}

	public void SetNextTime(float nextTime)
	{
	}

	public float GetTimeLeft()
	{
		return 0f;
	}
}
