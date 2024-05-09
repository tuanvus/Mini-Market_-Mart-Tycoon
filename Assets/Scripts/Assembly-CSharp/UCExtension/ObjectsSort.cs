using UnityEngine;

namespace UCExtension
{
	public class ObjectsSort : MonoBehaviour
	{
		[SerializeField]
		private SortMode sortMode;

		[SerializeField]
		private float distanceBetweenX;

		[SerializeField]
		private float distanceBetweenY;

		[SerializeField]
		private float distanceBetweenZ;

		[SerializeField]
		private bool sortByX;

		[SerializeField]
		private bool sortByY;

		[SerializeField]
		private bool sortByZ;

		public void Sort()
		{
		}
	}
}
