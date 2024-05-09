using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UCExtension.Common;
using UnityEngine;
using UnityEngine.Events;

public class Player : Character
{
	[CompilerGenerated]
	private sealed class _003CIEWaitCatchThief_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Player _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CIEWaitCatchThief_003Ed__29(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private const float DELAY_INTERACTION_TIME = 0.03f;

	[SerializeField]
	private PlayerMover mover;

	[SerializeField]
	private AnimationEventTrigger eventTrigger;

	[SerializeField]
	private Transform collectPosition;

	[SerializeField]
	private Transform cameraFollowPosition;

	[SerializeField]
	private PlayerSkinController skinController;

	[SerializeField]
	private ThiefCatcher thiefCatcher;

	[SerializeField]
	private RecylableObject disapearEffect;

	[SerializeField]
	private Product moneyPrefab;

	private Dictionary<int, IPlayerStayTrigger> stayingTriggers;

	private bool isDisabling;

	private bool isCatchingThief;

	private bool isTriggeredCatchEvent;

	private ThiefBot caughtThief;

	[SerializeField]
	private DelayCaller caller;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void EditorMove()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void SetUp()
	{
	}

	protected override void RegisterEvents()
	{
	}

	private void UnregisterEvent()
	{
	}

	public void GoToNextMap()
	{
	}

	private void OnThiefAppear()
	{
	}

	private void OnFinishThiefCatch()
	{
	}

	private void CatchThief(ThiefBot thief)
	{
	}

	private void OnCatchEvent()
	{
	}

	[IteratorStateMachine(typeof(_003CIEWaitCatchThief_003Ed__29))]
	private IEnumerator IEWaitCatchThief()
	{
		return null;
	}

	private void OnThiefCaught()
	{
	}

	public void MoveToCatchPos(ThiefBot thief)
	{
	}

	private void OnChangeMovementInput(Vector2 movementInput)
	{
	}

	private void ChangeHat(HatData itemData)
	{
	}

	public void Collect(Product product)
	{
	}

	public void RefocusCamera()
	{
	}

	public void ReceiveMoney(int money, Transform startPos, UnityAction finish = null)
	{
	}
}
