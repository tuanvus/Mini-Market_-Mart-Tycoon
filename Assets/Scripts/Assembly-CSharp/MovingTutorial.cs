using System.Collections.Generic;
using UnityEngine;

public class MovingTutorial : MonoBehaviour
{
	[SerializeField]
	private float time;

	[SerializeField]
	private Transform hand;

	[SerializeField]
	private List<Transform> paths;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnChangeMovementInput(Vector2 input)
	{
	}

	private void DoAnim()
	{
	}
}
