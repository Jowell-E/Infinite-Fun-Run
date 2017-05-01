using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 4f;
	public float jumpVelocity = 10f;

	public ParticleSystem burnerFx;
	Rigidbody2D rb2d;
	bool grounded = false;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		rb2d.velocity = new Vector2 (speed, rb2d.velocity.y);

		if (Input.GetKey (KeyCode.Space)) {
			if (grounded) {
				rb2d.velocity = new Vector2 (rb2d.velocity.x, jumpVelocity);
				grounded = false;
				burnerFx.Play ();
			}
		}
	}

	void OnCollisionEnter2D (Collision2D other){
		if (transform.position.y > other.transform.position.y) {
			grounded = true;
			burnerFx.Stop ();
		}
	}
}
