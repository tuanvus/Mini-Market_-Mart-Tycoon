using System;
using System.Collections.Generic;

public static class Alarm
{
	public class Entry
	{
		public int index;

		public string title;

		public string msg;

		public DateTime date;
	}

	public static List<Entry> entrys;

	private static string PREFIX;

	public static int AlarmCount => 0;

	static Alarm()
	{
	}

	public static void Init()
	{
	}

	public static void Register(string key, string title, string message, DateTime alarmTime, bool isSoundEnabled = false)
	{
	}

	public static void Register(string key, string title, string message, double intervalHours, bool isSoundEnabled = false)
	{
	}

	private static int RegisterInternal(string title, string message, DateTime date, bool isSoundEnabled = false)
	{
		return 0;
	}

	public static void Unregister(string key)
	{
	}

	private static void UnregisterInternal(int index)
	{
	}

	public static void AllUnregister()
	{
	}

	private static List<Entry> GetUnregisterEntrys(int index)
	{
		return null;
	}
}
