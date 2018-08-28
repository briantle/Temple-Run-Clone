using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{
	private CharacterController controller;
	public bool isDead = false;
	public float movementSpeed;
	// Used to apply gravity to our character
	public float verticalVelocity = 0.0f;

	// Use this for initialization
	void Start () {
		controller = gameObject.GetComponent<CharacterController> ();
		// if forgot to set a value for the speed, default it to 5
		if (movementSpeed == 0)
			movementSpeed = 5f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 moveVector = Vector3.zero;
		// If our player is on the ground, then reset the vertical velocity
		if (controller.isGrounded)
			verticalVelocity -= 0.5f;
		// Otherwise, we want to apply gravity to make our character fall down.
		// We are going to be using the gravity set in our project settings
		else {
			verticalVelocity -= Physics.gravity.y * Time.deltaTime;
			// This is going to check if our player falls out of bounds
			RaycastHit hit;
			// If our character falls down and there isn't an object below him, he's dead
			if (!Physics.Raycast (transform.position, -Vector3.up, out hit)) {
				Debug.Log ("Player has fallen out of bounds");
				isDead = true;
			}
		}
		// Applies gravity to player
		moveVector.y = verticalVelocity;
		// Player can strafe left or right
		moveVector.x = Input.GetAxisRaw("Horizontal") * movementSpeed;
		// Player's forward movement
		moveVector.z = movementSpeed;
		// Player will constantly move forward
		controller.Move (moveVector * Time.deltaTime);
	}
}
