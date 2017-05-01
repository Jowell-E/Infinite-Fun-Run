using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

	public Text UIText;

	float score;
	float bonusScore;
	// Update is called once per frame
	void Update () {
		score = transform.position.x + bonusScore;

		UIText.text = "Score: " + (int)(score * 100);
	}

	public void ChangeScore(int amount){
		bonusScore += amount;
	}
}
