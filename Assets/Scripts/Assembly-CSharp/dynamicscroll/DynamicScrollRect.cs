using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace dynamicscroll
{
	public class DynamicScrollRect : ScrollRect
	{
		public DynamicScrollRectEvent onEndDrag;

		public DynamicScrollRectEvent onBeginDrag;

		public DynamicScrollRectEvent onStopMoving;

		public MovementType realMovementType;

		public bool needElasticReturn;

		public Vector2 clampedPosition;

		private bool dragging;

		private bool isWaitingToStop;

		private Vector2 pointerStartLocalCursor;

		protected override void Awake()
		{
		}

		public override void OnBeginDrag(PointerEventData eventData)
		{
		}

		public override void OnEndDrag(PointerEventData eventData)
		{
		}

		public override void OnDrag(PointerEventData eventData)
		{
		}

		private float RubberDelta(float overStretching, float viewSize)
		{
			return 0f;
		}

		protected override void LateUpdate()
		{
		}

		private void OnMovementStop()
		{
		}

		private void EnsureLayoutHasRebuilt()
		{
		}

		private Vector2 CalculateOffset(Vector2 delta)
		{
			return default(Vector2);
		}

		internal Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Vector2 delta)
		{
			return default(Vector2);
		}
	}
}
