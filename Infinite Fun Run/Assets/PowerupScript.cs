using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupScript : MonoBehaviour {

	int bonus = 10;
	void OnTriggerEnter2D (Collider2D other){
		if (other.tag == "Player") {
			Camera.main.GetComponent<HUDScript> ().ChangeScore (bonus);
		}
		Destroy (gameObject);
	}
}
