using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ComboEffect : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CIEShowCombo_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ComboEffect _003C_003E4__this;

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
		public _003CIEShowCombo_003Ed__13(int _003C_003E1__state)
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

	[SerializeField]
	private Image comboImage;

	[SerializeField]
	private Text comboText;

	[SerializeField]
	private float scale;

	[SerializeField]
	private float timeScale;

	[SerializeField]
	private float timeShow;

	[SerializeField]
	private List<Sprite> comboSprites;

	[SerializeField]
	private List<Color> comboColors;

	private Tween tween;

	private IEnumerator ieShow;

	private void Start()
	{
	}

	public void ShowCombo(int comboCount)
	{
	}

	private Sprite GetComboSprite(int combo)
	{
		return null;
	}

	private Color GetComboColor(int combo)
	{
		return default(Color);
	}

	[IteratorStateMachine(typeof(_003CIEShowCombo_003Ed__13))]
	private IEnumerator IEShowCombo()
	{
		return null;
	}
}
