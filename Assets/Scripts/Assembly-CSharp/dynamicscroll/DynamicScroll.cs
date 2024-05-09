using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;
using pooling;

namespace dynamicscroll
{
	public class DynamicScroll<T, T1> where T : class where T1 : DynamicScrollObject<T>
	{
		public const float CONTENT_OFFSET_FIXER_LIMIT = 1000f;

		public float spacing;

		public readonly Pooling<T1> objectPool;

		public bool centralizeOnStop;

		public Action<Vector2> OnDragEvent;

		public UnityEvent<PointerEventData> OnBeginDragEvent;

		public UnityEvent<PointerEventData> OnEndDragEvent;

		private VerticalLayoutGroup mVerticalLayoutGroup;

		private HorizontalLayoutGroup mHorizontalLayoutGroup;

		private GridLayoutGroup mGridLayoutGroup;

		private ContentSizeFitter mContentSizeFitter;

		private bool mIsVertical;

		private bool mIsHorizontal;

		private bool mIsDragging;

		private ScrollDirection mLastInvalidDirections;

		private ScrollRect.MovementType mMovementType;

		private Vector2 mNewAnchoredPosition;

		private Vector2 mScrollVelocity;

		private Vector2 mLastPos;

		private Vector2 mClampedPosition;

		private IList<T> infoList;

		private Tween forceMoveTween;

		public T1 CentralizedObject
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DynamicScrollRect ScrollRect
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public IList<T> RawDataList => null;

		public void Initiate(DynamicScrollRect scrollRect, IList<T> infoList, int startIndex, GameObject objReference, bool createMoreIfNeeded = true, int? forceAmount = null)
		{
		}

		private void SetCentralizedObject()
		{
		}

		public void ChangeList(IList<T> infoList, int startIndex = -1, bool resetContentPosition = false)
		{
		}

		private void CreateList(int startIndex)
		{
		}

		public void RefreshPosition()
		{
		}

		private void DisableGridComponents()
		{
		}

		private void OnScroll(Vector2 pos)
		{
		}

		private void OnBeginDrag(PointerEventData pointData)
		{
		}

		private void OnEndDrag(PointerEventData pointData)
		{
		}

		private void OnStopMoving(PointerEventData arg0)
		{
		}

		private void ApplyOffsetIfNeeded()
		{
		}

		private void StopScrollAndChangeContentPosition(Vector2 pos)
		{
		}

		private ScrollDirection LimitScroll()
		{
			return default(ScrollDirection);
		}

		public bool CanMove(ScrollDirection directions)
		{
			return false;
		}

		public void ToggleScroll(bool active)
		{
		}

		private void UpdateObjectsCentralizedPosition()
		{
		}

		public void MoveToIndex(int index, float? totalTime = null, float? timePerElement = null)
		{
		}

		public void SetIndex(int index)
		{
		}

		public T1 GetCentralizedObject()
		{
			return null;
		}

		public T1 GetLowest()
		{
			return null;
		}

		public T1 GetHighest()
		{
			return null;
		}
	}
}
