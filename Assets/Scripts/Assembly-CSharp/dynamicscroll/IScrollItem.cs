using UnityEngine;

namespace dynamicscroll
{
	public interface IScrollItem
	{
		int CurrentIndex { get; set; }

		RectTransform RectTransform { get; }

		void Reset();
	}
}
