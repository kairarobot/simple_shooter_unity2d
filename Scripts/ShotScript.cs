using UnityEngine;
using System.Collections;

public class ShotScript: MonoBehaviour
{
	public GameObject bulletPrefab; // declares a game object so we can use a prefab
	public bool coolDowntime; // the time in between before another shot is fired
	public AudioClip explosion; // declares the audio clip for the firing shots

	
	void Update()
	{
		// // if we input 'W' and the cooldown is not on, then it's okay to fire
		if (Input.GetKey (KeyCode.W) && coolDowntime == false) 
		{
			coolDowntime = true; // once a fire is shot, cool down is turned to true
			StartCoroutine ("coolDown"); // we call the function cool down to start it
			Fire ();	// we then call the function fire
		}
	}
	
	
	IEnumerator coolDown() // We use IEnumerator if we are using Coroutines in C#-- this is for timers
	{
			yield return new WaitForSeconds(0.5f); // waits for half a second
			coolDowntime = false; // after half a second passes, it's okay to fire again so cooldown is false
	}
	
	void Fire() // We call thsi function to instantiate
	{
		// So once the 'W' is pressed, we are instantiating or creating another game object from the bullet prefab
		GameObject bPrefab = Instantiate (bulletPrefab, transform.position, Quaternion.identity) as GameObject;


		audio.PlayOneShot (explosion); // we play the audio once it is fired

	}
	

}
