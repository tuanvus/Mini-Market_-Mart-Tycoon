using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

namespace UCExtension.GUI.Animation
{
	public class ObjectsScaleUpAnim : GUIAnim
	{
		[SerializeField]
		private List<Transform> scaleUpObjects;

		[SerializeField]
		private float timeScaleObject;

		[SerializeField]
		private float startScale;

		[SerializeField]
		private Ease ease;

		public override void Open(UnityAction finish = null)
		{
		}

		public override void Close(UnityAction finish = null)
		{
		}
	}
}
