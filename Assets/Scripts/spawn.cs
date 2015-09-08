using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {
	public Pillow pillow;
	public Vector3 startingPosPillow;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", 1, Random.Range((float) 1, (float) 3));
	}

	void Spawn(){
		Vector3 position = new Vector3 (Random.Range(startingPosPillow.x - 5, startingPosPillow.x + 5),
		                                startingPosPillow.y,
		                                Random.Range(startingPosPillow.z - 5, startingPosPillow.z + 5));
		Quaternion rotation = new Quaternion (0, 0, 0, 0);
		Instantiate (pillow, position, rotation);
	}
}
