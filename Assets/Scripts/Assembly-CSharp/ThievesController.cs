using System;
using System.Collections.Generic;
using UCExtension.Common;
using UnityEngine;

public class ThievesController : Service
{
	[SerializeField]
	private DataIdentifier identifier;

	[SerializeField]
	private int coinUsedToAppear;

	[SerializeField]
	private float spawnDelayTime;

	[SerializeField]
	private ThiefBot thiefPrefab;

	[SerializeField]
	private List<Transform> positions;

	public static Action OnThiefAppear;

	public static Action OnThiefEscape;

	private bool isThiefStaying;

	private float remainingTimeToSpawn;

	private void Start()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void Update()
	{
	}

	public Transform GetEscapePosition()
	{
		return null;
	}

	private void SpawnThief(CashierDesk desk)
	{
	}

	private void OnThiefDisappear()
	{
	}

	private Transform NearestPos(CashierDesk desk)
	{
		return null;
	}

	private void Save()
	{
	}

	private void Load()
	{
	}
}
