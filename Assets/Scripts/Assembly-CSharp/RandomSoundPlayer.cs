using System.Collections.Generic;
using UnityEngine;

public class RandomSoundPlayer : MonoBehaviour
{
	[SerializeField]
	private float minTimeDelay;

	[SerializeField]
	private float maxTimeDelay;

	[SerializeField]
	private List<AudioClip> soundClips;

	private float nextTimePlaySound;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void PlaySound()
	{
	}
}
