using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetection : MonoBehaviour
{
    public Text deadText;
	void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Platform")
            hit.gameObject.GetComponent<DestroyAtDistance>().steppedOn = true;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Falling")
        {
            deadText.gameObject.SetActive(true);
            gameObject.GetComponent<Player>().setDead();
        }
        if (other.gameObject.tag == "Powerup")
            Destroy(other.gameObject);
    }
}
