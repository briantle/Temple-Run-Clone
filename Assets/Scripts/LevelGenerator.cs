using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

	public float distanceToInstantiate = 50f;
	public GameObject platform;
	private Vector3 currPosition = Vector3.zero;

	void Update(){
		Transform trans = gameObject.transform;
		if (Vector3.Distance(Camera.main.transform.position, currPosition) < distanceToInstantiate){
				Instantiate(platform, currPosition, trans.rotation, gameObject.transform);
				currPosition += new Vector3(0, 0, 10);
		}
	}
}
