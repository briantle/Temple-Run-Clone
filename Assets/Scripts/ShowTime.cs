using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowTime : MonoBehaviour {

	public Text timeText;
	// Update is called once per frame
	void Update () {
		timeText.text = "Time: " + (int) Time.realtimeSinceStartup;
	}
}
