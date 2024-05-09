using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class CustomerBot : Bot<CustomerBot>
{
	[SerializeField]
	[Header("Customer bot")]
	private Transform packagingBoxPosition;

	[SerializeField]
	private StackCollector bigCollector;

	[SerializeField]
	private StackCollector smallCollector;

	[SerializeField]
	private Transform cashPosition;

	[SerializeField]
	private RequirementUI uiRequirementPrefab;

	[SerializeField]
	private Transform requirementFollowTarget;

	[Header("Model")]
	[SerializeField]
	private Transform modelParent;

	[SerializeField]
	private List<GameObject> models;

	private GameObject currentModel;

	public Action<CustomerBot> OnGoHome;

	public List<ProductRequirement> Orders
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

	public StoreShelf TargetStore
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

	public RequirementUI OrderDisplay
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

	public PackagingBox CurrentBox
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

	public Transform CashPosition => null;

	protected override void Awake()
	{
	}

	public void SetOrders(List<ProductRequirement> orders)
	{
	}

	public void ResetStates()
	{
	}

	private void ResetModel()
	{
	}

	protected override void RegisterEvents()
	{
	}

	private void ResetCollector()
	{
	}

	public override void Recyle()
	{
	}

	public void GoHome(PackagingBox box, UnityAction<Transform> callback)
	{
	}

	public override void OnCollectObject()
	{
	}

	public override void OnEmptyObject()
	{
	}

	public CustomerBot()
	{
		((Bot<>)(object)this)._002Ector();
	}
}
