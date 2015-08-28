using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {
	public GameObject pillow;
	public Vector3 startingPosPillow;
	// Use this for initialization
	void Start () {
		startingPosPillow = pillow.transform.position;
		InvokeRepeating ("Spawn", 1, Random.Range((float) 0.01, (float) (.01)));
	}

	void Spawn(){
		//Sprite[] grillSprites = Resources.LoadAll<Sprite>("GrillSprites");
		//SpriteRenderer renderer = pillow.AddComponent<SpriteRenderer>();
		//renderer.sprite = grillSprites[Random.Range(0, grillSprites.Length - 1)];
		Vector3 position = new Vector3 (Random.Range(startingPosPillow.x - 5, startingPosPillow.x + 5),
		                                startingPosPillow.y,
		                                Random.Range(startingPosPillow.z - 5, startingPosPillow.z + 5));
		Quaternion rotation = new Quaternion (0, 0, 0, 0);
		Instantiate (pillow, position, rotation);
	}
}
