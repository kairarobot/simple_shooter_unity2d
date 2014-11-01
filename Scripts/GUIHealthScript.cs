using UnityEngine;
using System.Collections;

public class GUIHealthScript : MonoBehaviour {

	// this updates every frame
	// shows the GUI for the "HP"
	void Update ()
	{
		//references and displays the static variable playerHealth found in Player script
		float hp = Player.playerHealth;
		guiText.text = "HP: " + hp;
	}
}
