using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowTime : MonoBehaviour {

	public Text timeText;
    public Text fpsText;
    private float deltaTime;
	public float finalTime = 0f;
	private Player playa;
	
	void Start(){
		playa = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Shows Framerate, this is to know how our game is performing
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        float fps = 1.0f / deltaTime;
        fpsText.text = Mathf.Ceil(fps).ToString();
        // As long as the player is alive, we want to keep a timer of how longer they have been running
        if (playa.enabled){
			timeText.text = "Time: " + (int) Time.realtimeSinceStartup;
			finalTime = Time.realtimeSinceStartup;
		}
	}
}
