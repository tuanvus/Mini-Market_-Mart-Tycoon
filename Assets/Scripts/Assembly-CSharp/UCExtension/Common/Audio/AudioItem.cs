using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;

namespace UCExtension.Common.Audio
{
	public class AudioItem : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CPlaySoundCoroutine_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AudioItem _003C_003E4__this;

			public AudioClip audioClip;

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
			public _003CPlaySoundCoroutine_003Ed__7(int _003C_003E1__state)
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

		private AudioSource source;

		private UnityAction finished;

		private AudioSource Source => null;

		public bool IsPlaying => false;

		public void PlaySoundOnce(AudioClip audioClip)
		{
		}

		[IteratorStateMachine(typeof(_003CPlaySoundCoroutine_003Ed__7))]
		private IEnumerator PlaySoundCoroutine(AudioClip audioClip)
		{
			return null;
		}

		public void PlaySoundLoop(AudioClip audioClip)
		{
		}

		public void Play()
		{
		}

		public void StopSound()
		{
		}

		public void PauseSound()
		{
		}

		public void UnPauseSound()
		{
		}

		public void OnCompleted(UnityAction callback)
		{
		}

		public void Recyle()
		{
		}

		public void SetMixer(AudioMixerGroup mixerGroup)
		{
		}
	}
}
