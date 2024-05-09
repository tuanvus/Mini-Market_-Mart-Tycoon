using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CarCustomer : SavableObject, IPlayerStayTrigger, IPlayerEnterTrigger, IPlayerExitTrigger
{
	[SerializeField]
	private int moneyEarnedToUnlock;

	[SerializeField]
	private float delayComeInTime;

	[SerializeField]
	private StackCollector collector;

	[SerializeField]
	private Transform moneyPayTransform;

	[SerializeField]
	private Transform requirementFT;

	[SerializeField]
	private UIMultiRequirement uiMultiRequirementPrefab;

	[SerializeField]
	private TutorialFocus tutorial;

	[SerializeField]
	private Car car;

	[SerializeField]
	private Collider _mCollider;

	[SerializeField]
	private List<AudioClip> comeInSoundClips;

	[SerializeField]
	private List<AudioClip> leaveSoundClips;

	public static UnityAction<float> OnStayingTimeReduceEvent;

	public static UnityAction OnComeInEvent;

	public static UnityAction OnLeaveEvent;

	public static UnityAction<List<ProductRequirement>> OnUpdateRequirements;

	private List<ProductRequirement> requirements;

	private UIMultiRequirement spawnedMultiRequirement;

	private Player stayingPlayer;

	private bool isStaying;

	private bool isLeaving;

	private bool isLoadedData;

	private float stayingTimeRemaining;

	private float comeInTimeRemainning;

	private bool isUnlocked => false;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void Update()
	{
	}

	private int GetTimeByOrder(int time)
	{
		return 0;
	}

	public void ComeIn()
	{
	}

	public void Leave(float multiplier = 1f)
	{
	}

	private void Pay(float multiplier, UnityAction finish)
	{
	}

	private void Save()
	{
	}

	public void Load()
	{
	}

	private void SpawnRequirementsUI(List<ProductRequirement> requirements)
	{
	}

	private void ShowOrderUI()
	{
	}

	public void OnPlayerStay(Player player)
	{
	}

	public void OnPlayerExit(Player player)
	{
	}

	public void OnPlayerEnter(Player player)
	{
	}
}
