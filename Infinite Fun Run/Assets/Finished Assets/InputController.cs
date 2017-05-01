using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

	public float speed = 0f;
	public float jumpVelocity = 0f;
	public bool isRed = false;
	float redTimer = 10f;
	public Sprite redFace;
	public Sprite blueFace;

	private bool grounded;
	Rigidbody2D rb2d;

	public ParticleSystem burnerfx;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (isRed) {
			redTimer -= Time.deltaTime;
			if (redTimer < 0) {
				isRed = false;
				speed = speed / 2;
				GetComponent<SpriteRenderer> ().sprite = blueFace;
			}
		}
		rb2d.velocity = new Vector2 (speed, rb2d.velocity.y);


		if (Input.GetKey (KeyCode.Space) && grounded == true) {
			burnerfx.Play ();
			rb2d.velocity = new Vector2 (rb2d.velocity.x, jumpVelocity);
			grounded = false;
		}
	}

	public void ActivateRed(){
		if (!isRed) {
			isRed = true;
			redTimer = 10f;
			speed = speed * 2;
			GetComponent<SpriteRenderer> ().sprite = redFace;
		}
	}

	void OnCollisionEnter2D (Collision2D other){
		if (transform.position.y > other.transform.position.y) {
			grounded = true;
			burnerfx.Stop ();
		}
	}
}
