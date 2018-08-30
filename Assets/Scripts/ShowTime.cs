using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowTime : MonoBehaviour {

	public Text timeText;
	public float finalTime = 0f;
	public Player playa;
	
	void Start(){
		playa = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update () {
		if (playa.enabled){
			timeText.text = "Time: " + (int) Time.realtimeSinceStartup;
			finalTime = Time.realtimeSinceStartup;
		}
	}
}
