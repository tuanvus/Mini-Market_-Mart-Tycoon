using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UCExtension.UI
{
	[RequireComponent(typeof(Image))]
	[RequireComponent(typeof(ScrollRect))]
	public class ScrollSnapRect : MonoBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler
	{
		[CompilerGenerated]
		private sealed class _003CIEUpdate_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ScrollSnapRect _003C_003E4__this;

			private float _003ClastTime_003E5__2;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CIEUpdate_003Ed__35(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		public static ScrollSnapRect Ins;

		[Tooltip("Set starting page index - starting from 0")]
		public int startingPage;

		[Tooltip("Threshold time for fast swipe in seconds")]
		public float fastSwipeThresholdTime;

		[Tooltip("Threshold time for fast swipe in (unscaled) pixels")]
		public int fastSwipeThresholdDistance;

		[Tooltip("How fast will page lerp to target position")]
		public float decelerationRate;

		[Tooltip("Button to go to the previous page (optional)")]
		public Button prevButton;

		[Tooltip("Button to go to the next page (optional)")]
		public Button nextButton;

		[Tooltip("Sprite for unselected page (optional)")]
		public Sprite unselectedPage;

		[Tooltip("Sprite for selected page (optional)")]
		public Sprite selectedPage;

		[Tooltip("Container with page images (optional)")]
		public Transform pageSelectionIcons;

		[Tooltip("Container with page count (optional)")]
		public Text pageCountText;

		[SerializeField]
		private bool unscaledTime;

		[SerializeField]
		private bool hideTransitionButton;

		private int _fastSwipeThresholdMaxLimit;

		private ScrollRect _scrollRectComponent;

		private RectTransform _scrollRectRect;

		private RectTransform _container;

		public bool autoInit;

		private bool _horizontal;

		private int _pageCount;

		private int _currentPage;

		private bool _lerp;

		private Vector2 _lerpTo;

		private List<Vector2> _pagePositions;

		private bool _dragging;

		private float _timeStamp;

		private Vector2 _startPosition;

		public bool _showPageSelection;

		private int _previousPageSelectionIndex;

		public Image pageSelectionPrefab;

		private List<Image> _pageSelectionImages;

		public UnityAction<int> onPageChange;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		[IteratorStateMachine(typeof(_003CIEUpdate_003Ed__35))]
		private IEnumerator IEUpdate()
		{
			return null;
		}

		public void GoToPage(int page)
		{
		}

		public void Reset(int pageCount = 0)
		{
		}

		public void SetHighPage(int id)
		{
		}

		private void Update()
		{
		}

		private void SetPagePositions()
		{
		}

		private void SetPage(int aPageIndex)
		{
		}

		public void LerpToPage(int aPageIndex)
		{
		}

		private void CheckButtonState(int aPageIndex)
		{
		}

		private void InitPageSelection(int pageCount)
		{
		}

		private void SetPageSelection(int aPageIndex)
		{
		}

		private void NextScreen()
		{
		}

		private void PreviousScreen()
		{
		}

		private int GetNearestPage()
		{
			return 0;
		}

		public void OnBeginDrag(PointerEventData aEventData)
		{
		}

		public void OnEndDrag(PointerEventData aEventData)
		{
		}

		public void OnDrag(PointerEventData aEventData)
		{
		}
	}
}
