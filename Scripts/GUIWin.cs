using UnityEngine;
using System.Collections;

public class GUIWin : MonoBehaviour {


	// Update is called once every frame
	void Update()
	{
		// This hides the intial GUI text on the screen on game start
		guiText.enabled = false;

		// Checks if the score is equal to 5 and if it is, then it displays the GUI
		if (Asteroid.score == 5)
		{
			guiText.enabled = true;
			guiText.text = "You Win!";
		}
	}
}
