using UnityEngine;

namespace UCExtension.UI
{
	public class FadingSpriteRenderer : MonoBehaviour
	{
		[SerializeField]
		private bool isAutoPlay;

		[SerializeField]
		private bool isCollide;

		[SerializeField]
		private SpriteRenderer mainSR;

		[SerializeField]
		private float timeDo;

		[SerializeField]
		private float timeDo2;

		[SerializeField]
		private float fadeFull;

		[SerializeField]
		private float fade;

		[SerializeField]
		private int loop;

		private void Start()
		{
		}

		public void PlayEffect(int loop)
		{
		}

		public void StopEffect()
		{
		}
	}
}
