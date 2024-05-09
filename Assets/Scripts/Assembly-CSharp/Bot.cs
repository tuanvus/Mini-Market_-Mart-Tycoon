using System.Runtime.CompilerServices;
using UnityEngine;

public class Bot<T> : Character where T : Bot<T>
{
	[SerializeField]
	private DelayCaller Caller;

	private Transform targetMove;

	public BotMover Mover
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private bool isReachedTarget => false;

	public bool CanInteraction => false;

	public StateMachine<T> StateMachine
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	protected override void Awake()
	{
	}

	protected virtual void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void SetDestination(Transform destination)
	{
	}

	public void UpdateDestination()
	{
	}

	protected virtual void OnStopMove()
	{
	}

	protected virtual void OnStartMove()
	{
	}
}
