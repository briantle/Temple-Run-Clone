using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour {

    public string powerupType;

	// Update is called once per frame
	void Update () {
        transform.Rotate(transform.rotation.x, 1, transform.rotation.z);		
	}
	public IEnumerator ApplyPower(GameObject player)
	{
		// Can run faster for 10 seconds
		if (powerupType == "SPEED") {
			player.GetComponent<Player> ().movementSpeed += 5f;
			yield return new WaitForSeconds (10.0f);
			player.GetComponent<Player> ().movementSpeed -= 5f;
		}
		// Can jump higher for 10 seconds
		else if (powerupType == "JUMP") {
			player.GetComponent<Player> ().jumpHeight = 1.5f;
			yield return new WaitForSeconds (10.0f);
			player.GetComponent<Player> ().jumpHeight = 1f;
		}
		// Invulnerable to collisions for 5 seconds
		else if (powerupType == "INVINCIBLE") {
			player.GetComponent<Player> ().invulnerable = true;
			yield return new WaitForSeconds (5f);
			player.GetComponent<Player> ().invulnerable = false;
		}
	}
}
