using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

	public GameObject platform;
	private Vector3 currPosition = Vector3.zero;
	void Awake () {
		Transform trans = gameObject.transform;
		for (int i = 0; i < 10; i++){
			Instantiate(platform, currPosition, trans.rotation);
			currPosition += new Vector3(0, 0, 10);
		}
	}
}
