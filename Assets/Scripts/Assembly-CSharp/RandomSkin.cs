using System.Collections.Generic;
using UnityEngine;

public class RandomSkin : MonoBehaviour
{
	[SerializeField]
	private bool autoChangeSkin;

	[SerializeField]
	private Renderer skinRenderer;

	[SerializeField]
	private List<Material> skinMaterials;

	private void Awake()
	{
	}

	public void ChangeRandomSkin()
	{
	}
}
