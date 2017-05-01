using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObj : MonoBehaviour {

	public GameObject obj;

	public float spawnMin;
	public float spawnMax;
	// Use this for initialization
	void Start () {
		Invoke ("Spawn", Random.Range (spawnMin, spawnMax));
	}

	void Spawn(){
		Instantiate (obj, transform.position, Quaternion.identity);

		Invoke ("Spawn", Random.Range (spawnMin, spawnMax));	
	}

}
