using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class TutorialFocus : SavableObject
{
	[SerializeField]
	private bool autoShow;

	[SerializeField]
	private bool showPointer;

	[SerializeField]
	private bool focusCamera;

	[SerializeField]
	private float timeFocus;

	[SerializeField]
	private TransformFollowerUI tutorialPointerPrefab;

	[SerializeField]
	private Transform cameraFollowTarget;

	[SerializeField]
	private Transform tutorialPointerFollowTarget;

	private TransformFollowerUI currentPointer;

	private bool IsShowed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsShowing
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private void Awake()
	{
	}

	public void CheckToShow()
	{
	}

	public void Show(UnityAction finish = null)
	{
	}

	private void SpawnTutorialPointer()
	{
	}

	public void HideTutorial()
	{
	}

	public void FocusCamera(UnityAction finish = null)
	{
	}
}
