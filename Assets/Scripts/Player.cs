using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{
	private CharacterController controller;
	private Rigidbody[] bodies;
    private bool jumped = false;
	public float movementSpeed;
	// Used to apply gravity to our character
	public float verticalVelocity = 0.0f;
	public float gravity = 12f;
    public Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
		bodies = GetComponentsInChildren<Rigidbody> ();
		setKinematic (true);
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
        {
            verticalVelocity -= 0.5f;
            jumped = false;
        }
        // Otherwise, we want to apply gravity to make our character fall down.
        // We are going to be using the gravity set in our project settings
        else
            verticalVelocity -= gravity * Time.deltaTime;

		// Player is allowed to jump, but not double jump
        if (Input.GetButtonDown("Jump") && !jumped)
        {
			// Stop the running animation and play the jumping animation

			// How high the player will jump
            verticalVelocity = 6.5f;
			// Prevents double jump
            jumped = true;
        }

		// Applies gravity to player
		moveVector.y = verticalVelocity;
		// Player can strafe left or right
		moveVector.x = Input.GetAxisRaw ("Horizontal") * movementSpeed;
		// Player's forward movement
		moveVector.z = movementSpeed;
		// Player will constantly move forward
		controller.Move (moveVector * Time.deltaTime);
	}
    public void setDead()
    {
        // Ragdoll physics
        setKinematic(false);
        // Disable animator 
        anim.enabled = false;
        gameObject.GetComponent<Player>().enabled = false;

    }
	public void setKinematic(bool isKinematic)
	{
		foreach (Rigidbody rb in bodies)
			rb.isKinematic = isKinematic;
	}

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Trap")
            setDead();
    }
}
