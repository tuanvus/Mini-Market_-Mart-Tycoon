using DG.Tweening;
using UnityEngine;

public class NotificationAnim : MonoBehaviour
{
	[SerializeField]
	private bool autoPlay;

	[SerializeField]
	private Vector3 stretchScale;

	[SerializeField]
	private Vector3 stretchScale2;

	[SerializeField]
	private Vector3 normalScale;

	[SerializeField]
	private Vector3 squashUp;

	private RectTransform rect;

	[SerializeField]
	private float TimeMove;

	[SerializeField]
	private float MoveDistance;

	[SerializeField]
	private Vector3 TargetScale;

	[SerializeField]
	private Vector3 OriginalScale;

	[SerializeField]
	private Ease MoveEase;

	[SerializeField]
	private Ease ScaleEase;

	private Vector3 originalPos;

	private Sequence sequence;

	private void Awake()
	{
	}

	public void PlayEffect()
	{
	}

	public void StopEffect()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
