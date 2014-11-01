using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {

	public static float score =0.0f; // we set a public variable score

	/*We are creating the speed, direction, and movement of the projectiles
	  which can also be used for other objects*/
	
	// Variables
	// Speed of the object
	public Vector2 speed = new Vector2(10,10);
	
	// Direction of the object
	public Vector2 direction = new Vector2 (0,1);
	
	// Declaring a Vector2 movement which we will use for storage below
	private Vector2 movement;
	
	
	// This updates the frame every second
	void Update () 
	{
		
		// Movement of the object multiplied by its direction and speed	
		movement = new Vector2 (speed.x * direction.x, speed.y * direction.y);
	}
	
	void FixedUpdate()
	{
		// Once the movement has a value, we then assign it to the object's rigidybody
		rigidbody2D.velocity = movement;
	}
	
	// We need this function in order to make sure that there are no existing objects
	// outside of the window screen fore more than 3 seconds.
	// The game will crash if we have bullets or asteroids constantly instantiating. 
	void OnBecameInvisible()
	{
		Destroy(gameObject,3);
	}

	// Checking for collision on the asteroid
	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Bullet") // checks for bullet collision
		{
			score++; // increase score if the bullet hits the asteroid
			Destroy (collision.gameObject); // destorys the bullet
			Destroy(gameObject); // destorys the asteroid
		}
		
		if (collision.gameObject.tag == "Player") // checks for player collision
		{
			Player.playerHealth--; // decrease health if the player hits the asteroid
			Destroy(gameObject); // destorys the asteroid
		}
		
	}

}

