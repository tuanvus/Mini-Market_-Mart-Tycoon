using UCExtension.Common;
using UnityEngine;

public class TransformFollowerManager : Singleton<TransformFollowerManager>
{
	[SerializeField]
	private RectTransform worldFollowerParent;

	[SerializeField]
	private Canvas mainCavas;

	[SerializeField]
	private Camera _mCamera;

	public T SpawnControlPositionUI<T>(T prefab, Transform followTarget) where T : TransformFollowerUI
	{
		return null;
	}

	public Vector2 GetAnchorPos(RectTransform UIElementParent, Vector3 position)
	{
		return default(Vector2);
	}

	public Vector3 GetWorldPos(RectTransform UIElementParent, Vector3 position)
	{
		return default(Vector3);
	}

	private void TryGetCamera()
	{
	}

	public TransformFollowerManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
