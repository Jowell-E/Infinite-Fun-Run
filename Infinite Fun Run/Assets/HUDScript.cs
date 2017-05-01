using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour {

	public Text text;
	GameObject player;


	float Score;
	float bonusScore;
	void Start(){
		player = GameObject.FindGameObjectWithTag ("Player");
	}


	// Update is called once per frame
	void Update () {
		Score = player.transform.position.x + bonusScore;

		text.text = "Score: " + (int)Score * 100;
	}

	public void ChangeScore (int amount){
		bonusScore += amount;

	}
}
