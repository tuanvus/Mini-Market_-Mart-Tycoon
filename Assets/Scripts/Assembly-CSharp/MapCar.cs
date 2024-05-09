using UnityEngine;

public class MapCar : MonoBehaviour, IPlayerEnterTrigger, IPlayerExitTrigger
{
	[SerializeField]
	private int mapIndex;

	[SerializeField]
	private float timeWait;

	[SerializeField]
	private Transform popupFollowPosition;

	[SerializeField]
	private ProgressUI popupPrefab;

	[SerializeField]
	private Car car;

	private ProgressUI currentPopup;

	private Player stayingPlayer;

	private void Start()
	{
	}

	public void OnPlayerEnter(Player player)
	{
	}

	public void OnPlayerExit(Player player)
	{
	}

	private void GoToNextMap()
	{
	}
}
