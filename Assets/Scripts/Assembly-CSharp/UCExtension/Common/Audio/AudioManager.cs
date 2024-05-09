using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace UCExtension.Common.Audio
{
	public class AudioManager : Singleton<AudioManager>
	{
		[SerializeField]
		private int defaultAudioItemAmout;

		[SerializeField]
		private AudioMixer mainMixer;

		[SerializeField]
		private AudioItem audioItemPrefab;

		[SerializeField]
		private List<AudioClip> SFXClips;

		[SerializeField]
		private List<AudioClip> BGMusicClips;

		[SerializeField]
		[Range(0f, 1f)]
		private float defaultSfxVolume;

		[SerializeField]
		[Range(0f, 1f)]
		private float defaultBGMusicVolume;

		[SerializeField]
		private AudioClip buttonClickAudio;

		private int playingBGMusicIndex;

		private int playingBGMusicID;

		private AudioItem bgAudioItem;

		private Queue<AudioItem> UnuseAudioItems;

		private Dictionary<int, SoundPlayer> soundPlayers;

		public static Action<bool> OnChangeBGMusicSettingCallback;

		public static Action<bool> OnChangeSFXSettingCallback;

		public float SFXVolume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float BGMusicVolume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool IsSFXOn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsBGMusicOn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsAllOn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		private void SetMixerVolume(string key, float value)
		{
		}

		public bool ToggleBGMusic()
		{
			return false;
		}

		public bool ToggleSFX()
		{
			return false;
		}

		public bool TurnOnOffAll()
		{
			return false;
		}

		public void PlaySFX(int index)
		{
		}

		public void PlaySFX(AudioClip clip)
		{
		}

		private SoundPlayer GetSoundPlayer(int id)
		{
			return null;
		}

		public void PlayDelaySFX(AudioClip clip, float timeDelay)
		{
		}

		public void PlayButtonClickSFX()
		{
		}

		public void ChangeBGMusic(int index)
		{
		}

		public void ChangeBGMusic(AudioClip clip)
		{
		}

		public AudioItem PlaySound(AudioClip clip, AudioMixerGroupType mixerType, bool isLoop = false)
		{
			return null;
		}

		public void PauseBGMusic()
		{
		}

		public void UnPauseBGMusic()
		{
		}

		private AudioMixerGroup GetMixerGroup(AudioMixerGroupType mixerType)
		{
			return null;
		}

		private AudioItem GetAudioItem()
		{
			return null;
		}

		public void RecycleAudioItem(AudioItem item)
		{
		}

		public AudioManager()
		{
			((Singleton<>)(object)this)._002Ector();
		}
	}
}
