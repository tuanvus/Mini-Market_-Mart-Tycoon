using System;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class QOutline : MonoBehaviour
{
	public enum Mode
	{
		OutlineAll = 0,
		OutlineVisible = 1,
		OutlineHidden = 2,
		OutlineAndSilhouette = 3,
		SilhouetteOnly = 4
	}

	[Serializable]
	private class ListVector3
	{
		public List<Vector3> data;
	}

	private static HashSet<Mesh> registeredMeshes;

	[SerializeField]
	private Mode outlineMode;

	[SerializeField]
	private Color outlineColor;

	[Range(0f, 10f)]
	[SerializeField]
	private float outlineWidth;

	[Tooltip("Precompute enabled: Per-vertex calculations are performed in the editor and serialized with the object. Precompute disabled: Per-vertex calculations are performed at runtime in Awake(). This may cause a pause for large meshes.")]
	[SerializeField]
	[Header("Optional")]
	private bool precomputeOutline;

	[HideInInspector]
	[SerializeField]
	private List<Mesh> bakeKeys;

	[SerializeField]
	[HideInInspector]
	private List<ListVector3> bakeValues;

	private Renderer[] renderers;

	private Material outlineMaskMaterial;

	private Material outlineFillMaterial;

	private bool needsUpdate;

	public Mode OutlineMode
	{
		get
		{
			return default(Mode);
		}
		set
		{
		}
	}

	public Color OutlineColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public float OutlineWidth
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnValidate()
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Bake()
	{
	}

	private void LoadSmoothNormals()
	{
	}

	private List<Vector3> SmoothNormals(Mesh mesh)
	{
		return null;
	}

	private void CombineSubmeshes(Mesh mesh, Material[] materials)
	{
	}

	private void UpdateMaterialProperties()
	{
	}
}
