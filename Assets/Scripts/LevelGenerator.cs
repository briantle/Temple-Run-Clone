using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

	public float distanceToInstantiate = 100f;
	public GameObject platform;
	public GameObject wallTrap;
	private Vector3 currPosition = Vector3.zero;

	void Update(){
		Transform trans = gameObject.transform;
		if (Vector3.Distance(Camera.main.transform.position, currPosition) < distanceToInstantiate){
				Instantiate(platform, currPosition, trans.rotation, gameObject.transform);
				currPosition += new Vector3(Random.Range(-2, 3), Random.Range(-1, 2), Random.Range(10, 13));
		}
	}
}
