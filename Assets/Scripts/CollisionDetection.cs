using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
	void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Platform")
            hit.gameObject.GetComponent<DestroyAtDistance>().steppedOn = true;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Falling")
            gameObject.GetComponent<Player>().setDead();
    }
}
