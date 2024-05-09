using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace API.Sound
{
	public class SoundManager : MonoBehaviour
	{
		public static SoundManager Ins;

		public AudioMixer mainMix;

		private List<AudioSource> sourcePool;

		[SerializeField]
		private AudioSource musicSource;

		public List<AudioClip> sfxClips;

		public List<AudioClip> musicClips;

		public float onSFXVol;

		public float onMusicVol;

		private bool isMusicOn;

		private bool isSFXOn;

		public bool IsMusicOn => false;

		public bool IsSFXOn => false;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public bool TurnOnOffSFX()
		{
			return false;
		}

		public bool TurnOnOffMusic()
		{
			return false;
		}

		public void TurnOnOffSFX(bool IsOn)
		{
		}

		public void TurnOnOffMusic(bool IsOn)
		{
		}

		public AudioSource GetAudioSource()
		{
			return null;
		}

		public void PlayButtonSFX()
		{
		}

		public AudioSource PlaySFX(int sfxId, Transform parent = null, bool IsLoop = false)
		{
			return null;
		}

		public void ChangeBGM(int musicId)
		{
		}
	}
}
