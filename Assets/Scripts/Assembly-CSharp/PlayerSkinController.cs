using UnityEngine;

public class PlayerSkinController : MonoBehaviour
{
	[SerializeField]
	private bool autoChangeRandomHat;

	[SerializeField]
	private Transform HatRoot;

	[SerializeField]
	private GameObject CurrentHat;

	private void Awake()
	{
	}

	public void ChangeHat(HatData hat)
	{
	}

	public void ChangeRandomHat()
	{
	}
}
