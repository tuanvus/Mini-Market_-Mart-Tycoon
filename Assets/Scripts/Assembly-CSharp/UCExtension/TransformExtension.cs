using System.Collections.Generic;
using UnityEngine;

namespace UCExtension
{
	public static class TransformExtension
	{
		public static void SetXLocalPos(this Transform trans, float value)
		{
		}

		public static void SetYLocalPos(this Transform trans, float value)
		{
		}

		public static void SetZLocalPos(this Transform trans, float value)
		{
		}

		public static void SetXPos(this Transform trans, float value)
		{
		}

		public static void SetYPos(this Transform trans, float y)
		{
		}

		public static void SetZPos(this Transform trans, float value)
		{
		}

		public static void SetXLocalScale(this Transform trans, float value)
		{
		}

		public static void SetYLocalScale(this Transform trans, float value)
		{
		}

		public static void SetZLocalScale(this Transform trans, float value)
		{
		}

		public static void SetZEulerAngle(this Transform trans, float value)
		{
		}

		public static void SetYEulerAngle(this Transform trans, float value)
		{
		}

		public static void SetXEulerAngle(this Transform trans, float value)
		{
		}

		public static void SetZLocalEulerAngle(this Transform trans, float value)
		{
		}

		public static void SetYLocalEulerAngle(this Transform trans, float value)
		{
		}

		public static void SetXLocalEulerAngle(this Transform trans, float value)
		{
		}

		public static void SetZRotation(this Transform trans, float value)
		{
		}

		public static void SortChildByX(this Transform target, SortMode mode, float distance)
		{
		}

		public static void SortChildByY(this Transform target, SortMode mode, float distance)
		{
		}

		public static void SortChildByZ(this Transform target, SortMode mode, float distance)
		{
		}

		private static float GetStartPosBySortMode(SortMode mode, int totalChildCount, float distance)
		{
			return 0f;
		}

		public static float TotalNavmeshPathMagnitude(this Transform target, Vector3 destination)
		{
			return 0f;
		}

		public static List<Vector3> GetConeDirectionVectors(this Transform trans, float catchAngle, int numOfRay)
		{
			return null;
		}

		public static GameObject FindObjectByNameContain(this Transform transform, string name)
		{
			return null;
		}

		public static GameObject FindObjectByName(this Transform transform, string name)
		{
			return null;
		}

		public static GameObject FindObjectWithTag(this Transform transform, string tag)
		{
			return null;
		}

		public static Queue<Transform> GetChildQueue(this Transform transform)
		{
			return null;
		}

		public static void AddRange<T>(this Queue<T> queue, Queue<T> addQueue)
		{
		}

		public static List<Transform> GetChilds(this Transform transform)
		{
			return null;
		}

		public static List<GameObject> FindObjectsWithTag(this Transform parent, string tag)
		{
			return null;
		}

		public static List<Transform> FindTransformsWithTag(this Transform parent, string tag)
		{
			return null;
		}
	}
}
