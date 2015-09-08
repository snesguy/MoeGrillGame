using UnityEngine;
using System.Collections;

public class Pillow : MonoBehaviour {
	public GameObject pillow;
	public Material myMaterial;

	void Start()
	{
		Texture[] grillSprites = Resources.LoadAll<Texture>("GrillSprites");
		myMaterial.SetTexture ("_MainTex", grillSprites [Random.Range (0, grillSprites.Length - 1)]);
	}
}
