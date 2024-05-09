using UnityEngine;

public class CashierBot : Bot<CashierBot>
{
	[SerializeField]
	private CashierWorkPlace workPlace;

	public CashierWorkPlace WorkPlace => null;

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	public CashierBot()
	{
		((Bot<>)(object)this)._002Ector();
	}
}
