using UCExtension.Common;
using UnityEngine;
using UnityEngine.UI;

namespace UCExtension.UI
{
	public class JumpIcon : RecylableObject
	{
		[SerializeField]
		private Image mainImage;

		[SerializeField]
		private float range;

		[SerializeField]
		private float forceJump;

		[SerializeField]
		private float timeJump;

		[SerializeField]
		private float timeFade;

		public override void OnSpawn()
		{
		}
	}
}
