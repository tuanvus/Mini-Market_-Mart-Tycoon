using UnityEngine;

[RequireComponent(typeof(ScaleObject))]
[RequireComponent(typeof(BoxCollider))]
public class BackgroundHightlighter : MonoBehaviour, IPlayerEnterTrigger, IPlayerExitTrigger
{
	private ScaleObject bgObject;

	protected void Awake()
	{
	}

	public void OnPlayerEnter(Player player)
	{
	}

	public void OnPlayerExit(Player player)
	{
	}
}
