using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {

	public GameObject obj;

	public bool isPowerup;
	public float spawnMin = 1f;
	public float spawnMax = 3f;

	InputController player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<InputController> ();
		Invoke ("Spawn", Random.Range (spawnMin, spawnMax));
	}

	void Spawn(){
		Instantiate (obj, transform.position, Quaternion.identity);

		if (player.isRed && !isPowerup) {
			Invoke ("Spawn", 1);
		} else {
			Invoke ("Spawn",Random.Range (spawnMin, spawnMax));
		}
	}

}
