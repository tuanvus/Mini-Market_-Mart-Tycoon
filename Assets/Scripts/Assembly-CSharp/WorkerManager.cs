using System.Collections.Generic;
using UnityEngine;

public class WorkerManager : MonoBehaviour
{
	[SerializeField]
	private string tagName;

	[SerializeField]
	private List<ProductWorkPlace> inputWorkPlaces;

	[SerializeField]
	private List<ProductWorkPlace> outputWorkPlaces;

	public ProductWorkPlace GetNearestOutputWorkPlace()
	{
		return null;
	}

	public ProductWorkPlace GetOutputWorkPlace()
	{
		return null;
	}

	public ProductWorkPlace GetNearestInputWorkPlace(Dictionary<int, int> IDs)
	{
		return null;
	}

	public void GetNecessaryComponents()
	{
	}
}
