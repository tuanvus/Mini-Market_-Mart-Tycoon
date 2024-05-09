using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

namespace API.RemoteConfig
{
	public class RemoteConfigManager : MonoBehaviour
	{
		public static RemoteConfigManager Ins;

		public Action OnFetchComplete;

		public bool IsInitComplete;

		public bool IsUseRemoteConfig;

		public List<RemoteConfigData> RemoteDatas;

		private Dictionary<string, object> defaults;

		public bool IsFetchedDatas
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public RemoteConfigData GetValue(string key)
		{
			return null;
		}

		private void OnFirebaseInitCompleted()
		{
		}

		private void InitDefault()
		{
		}

		private void FetchData()
		{
		}

		private void FetchComplete(Task fetchTask)
		{
		}

		private void SetData()
		{
		}

		public void SetDefault(string key, object defaultValue)
		{
		}
	}
}
