using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	//we use this to determine the speed of the player
	public float speed = 1f;

	//health of character
	public static float playerHealth = 5.0f;

	// audio clip for player collision with asteroid
	public AudioClip pop;
	

	// Update is called once per frame
	void Update () {

		// this checks once we press 'D' that it moves right
		if (Input.GetKey (KeyCode.D))
		{	transform.position += new Vector3 (speed * Time.deltaTime, 0.0f, 0.0f);
			Clamp(); // this calls the the function clamp so we don't move off the screen
		}

		// this checks once we press 'A' that it moves left
		if (Input.GetKey (KeyCode.A))
		{
			transform.position -= new Vector3 (speed * Time.deltaTime, 0.0f, 0.0f);
			Clamp (); //this calls the function clamp so we don't move off the screen
		}


		// Checks if the player's health is less than 0 and if it is less than or equal to 0
		// then the player object or simply the player will be destroyed

		if (playerHealth <= 0)
		{
			Debug.Log ("working");
			Destroy(gameObject);
		}
	}

	// This is the function for making sure that the player remains on the screen
	void Clamp ()
	{
		// Get the lower-left world coordinate of the viewport and stores it to 'min'
		Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
		
		// Get the upper-right world coordinate of the viewport and stores it to 'max'
		Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
		
		// Get the coordinates of the player and stores it as 'pos'
		Vector2 pos = transform.position;
		
		// Restrict the player from moving outside of the screen
		// stores player position x within the viewport
		// stores player postion y within the viewport
		pos.x = Mathf.Clamp (pos.x, min.x, max.x);
		pos.y = Mathf.Clamp (pos.y, min.y, max.y);
		
		// Assign the newly-restricted position value so the player can't move
		transform.position = pos;
	}

	void OnCollisionEnter2D (Collision2D collision) // detects for enemy collision to make sound
	{
		if (collision.gameObject.tag == "Enemy") // checks for enemy collision
		{
			audio.PlayOneShot (pop); // if collided with enemy then make the popping sound

		}
	}
}

