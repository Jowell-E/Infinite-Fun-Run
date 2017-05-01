using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform obj;
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (obj.position.x + 5, 0, -10);
	}
}
