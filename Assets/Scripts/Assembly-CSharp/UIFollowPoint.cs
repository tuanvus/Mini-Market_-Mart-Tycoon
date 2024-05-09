using DG.Tweening;
using UnityEngine;

public class UIFollowPoint<T> : MonoBehaviour where T : TransformFollowerUI
{
	[SerializeField]
	private T followerPrefab;

	private Tween destroyTween;

	private T spawnedFollower;

	public T Follower => null;

	private void RespawnFollower()
	{
	}

	public void DestroyFollower()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
