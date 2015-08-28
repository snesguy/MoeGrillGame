using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	public void load(string levelName)
	{
		Application.LoadLevel(levelName);
	}
}
