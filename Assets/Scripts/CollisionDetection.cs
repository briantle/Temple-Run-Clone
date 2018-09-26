using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CollisionDetection : MonoBehaviour
{
    public Text deadText;
	private Player p;

	void Start(){
		p = gameObject.GetComponent<Player> ();
	}

	void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Platform")
            hit.gameObject.GetComponent<DestroyAtDistance>().steppedOn = true;

		if (hit.gameObject.tag == "Obstacle" && !p.invulnerable)
			StartCoroutine ("Dead");
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Falling")
			StartCoroutine ("Dead");
		if (other.gameObject.tag == "Powerup") 
		{
			StartCoroutine(other.gameObject.GetComponent<Powerup> ().ApplyPower (gameObject));
			Destroy (other.gameObject);
		}
    }
	IEnumerator Dead(){
		p.setDead ();
		yield return new WaitForSeconds (2f);
		SceneManager.LoadScene ("Game Over");
	}
}
