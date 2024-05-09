using System.Collections.Generic;
using UnityEngine;

namespace UCExtension.Common
{
	public class ServiceLocator : AutoInstantiateSingletonUC<ServiceLocator>
	{
		private Dictionary<string, Service> services;

		public void RegisterService(Service service)
		{
		}

		public T GetService<T>(bool isSafe = true) where T : Service
		{
			return null;
		}

		private bool IsRegistered<T>() where T : MonoBehaviour
		{
			return false;
		}

		public ServiceLocator()
		{
			((AutoInstantiateSingletonUC<>)(object)this)._002Ector();
		}
	}
}
