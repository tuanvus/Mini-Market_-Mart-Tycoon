using DG.Tweening;
using UnityEngine;

public class DoorSliding : MonoBehaviour
{
	[SerializeField]
	private Transform leftDoor;

	[SerializeField]
	private Transform rightDoor;

	[SerializeField]
	private float distance;

	[SerializeField]
	private float timeDo;

	private Tween leftDoorTween;

	private Tween rightDoorTween;

	private int numInside;

	private void Start()
	{
	}

	private void Open()
	{
	}

	private void Close()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
