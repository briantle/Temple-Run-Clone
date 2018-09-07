using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour {

    public string powerupType;
	// Update is called once per frame
	void Update () {
        transform.Rotate(transform.rotation.x, 1, transform.rotation.z);		
	}
}
