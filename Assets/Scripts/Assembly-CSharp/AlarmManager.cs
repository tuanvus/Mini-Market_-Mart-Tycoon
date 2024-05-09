using System;
using UnityEngine;

public class AlarmManager : MonoBehaviour
{
	public static AlarmManager Ins;

	public ListNotificationSetting NotificationSettings;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnFirebaseInitComplete()
	{
	}

	private void RegisterAlarm()
	{
	}

	private void RegisterDailyAlarm()
	{
	}

	private static DateTime GetFireTickAfterDays(int days, int hour, int minute)
	{
		return default(DateTime);
	}

	private void AllUnRegister()
	{
	}
}
