using System;
using System.Collections;
using UnityEngine;

public class DestroyAtDistance: MonoBehaviour{
	public float distance = 45f;
	public bool steppedOn = false;
	void Update(){
		if (Vector3.Distance(Camera.main.transform.position, transform.position) > distance && steppedOn){
			Debug.Log("Destroyed: " + gameObject.name);
			Destroy(gameObject);
		}
	}
}