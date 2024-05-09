using System.Collections.Generic;
using Cinemachine;
using UCExtension.Common;
using UnityEngine;

public class CameraController : Service
{
	[SerializeField]
	private List<CinemachineVirtualCamera> cameras;

	[SerializeField]
	private CinemachineBrain mainCamera;

	private CinemachineVirtualCamera currentCamera;

	private int currentCameraIndex;

	public float TimeChangeCamera => 0f;

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	public void SetCameraFollow(Transform target, bool switchCam = false)
	{
	}

	private void SwitchCamera()
	{
	}
}
