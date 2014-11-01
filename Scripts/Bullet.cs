using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {


	
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
	
}
