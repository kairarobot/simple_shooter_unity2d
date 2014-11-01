using UnityEngine;
using System.Collections;

public class GUIScore : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {

		// Finds score varibale in Asteroid script and stores it as playerScore
		float playerScore = Asteroid.score;

		// Displays the GUI text of the player's score
		guiText.text = "Score: " + playerScore;
	}
}
