using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour {

	public Transform obj;
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (obj.transform.position.x + 6f, 0f, -15f);
	}
}
