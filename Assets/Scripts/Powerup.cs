using System;
using System.Collections;
using UnityEngine;

public class Powerup : MonoBehaviour 
{
	public String powerupType;
	void OnTriggerEnter(Collider collide)
	{
		if (collide.gameObject.tag == "Player")
			Debug.Log("Walked over powerup");
			// apply powerup
	}
}
