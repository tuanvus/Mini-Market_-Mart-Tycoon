using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ManufacturingMachine : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CMoveManuFacture_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ManufacturingMachine _003C_003E4__this;

		private List<ProductContainer>.Enumerator _003C_003E7__wrap1;

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
		public _003CMoveManuFacture_003Ed__18(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[SerializeField]
	private Transform inputPosition;

	[SerializeField]
	private Transform outputPosition;

	[SerializeField]
	private List<ProductContainer> inputContainers;

	[SerializeField]
	private ProductContainer outputContainer;

	[SerializeField]
	private ManufacturingMachineAnimationController animationController;

	[SerializeField]
	private List<float> manuTimes;

	[SerializeField]
	private List<int> capacities;

	[SerializeField]
	private float timeManufacture;

	private float timeManufactureRemaining;

	private bool isManufacturing;

	public Product manufacturingMaterial;

	public ParticleSystem eff;

	private bool canManufacture => false;

	private void Update()
	{
	}

	private void CheckToManufacture()
	{
	}

	private void FinishManufacture()
	{
	}

	private void StartManufacture(float timeManufacture)
	{
	}

	[IteratorStateMachine(typeof(_003CMoveManuFacture_003Ed__18))]
	private IEnumerator MoveManuFacture()
	{
		return null;
	}

	public void SetManuSpeedLevel(int level)
	{
	}

	public void SetCapacityLevel(int level)
	{
	}
}
