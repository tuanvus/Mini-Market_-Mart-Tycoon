using UnityEngine;
using UnityEngine.UI;

namespace UCExtension
{
	public static class CanvasUIExtension
	{
		public static void SetAlpha(this Graphic image, float alpha)
		{
		}

		public static void SetAlpha(this SpriteRenderer image, float alpha)
		{
		}

		public static void SetPivot(this RectTransform rectTransform, Vector2 pivot)
		{
		}

		public static Vector2 ConvertToCanvasAnchorPos(this Vector3 worldPosition, Camera camera, RectTransform canvasRect)
		{
			return default(Vector2);
		}
	}
}
