using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

	public bool isRed = false;
	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			if (!isRed) {
				Camera.main.GetComponent<HUD> ().ChangeScore (10);
			} else {
				other.GetComponent<InputController> ().ActivateRed ();
			}
			Destroy (gameObject);
		}
	}

}
