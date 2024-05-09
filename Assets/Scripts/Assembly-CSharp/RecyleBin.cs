using UnityEngine;

public class RecyleBin : MonoBehaviour, IPlayerStayTrigger
{
	[SerializeField]
	private Transform collectPoint;

	public void OnPlayerStay(Player player)
	{
	}

	public void Recyle(StackCollector collector)
	{
	}
}
