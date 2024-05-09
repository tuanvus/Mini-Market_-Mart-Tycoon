using System.Runtime.CompilerServices;
using UnityEngine;

public class WorkerBot : Bot<WorkerBot>
{
	[SerializeField]
	private WorkerManager manager;

	public ProductWorkPlace WorkPlaceTarget
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public RecyleBinWorkPlace TargetRecyleBin
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public WorkerManager Manager => null;

	private void Start()
	{
	}

	public WorkerBot()
	{
		((Bot<>)(object)this)._002Ector();
	}
}
