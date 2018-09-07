using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

	public float distanceToInstantiate = 100f;
    public GameObject[] platforms;
	public GameObject wallTrap;
	private Vector3 currPosition = Vector3.zero;

	void Update(){
		Transform trans = gameObject.transform;
		if (Vector3.Distance(Camera.main.transform.position, currPosition) < distanceToInstantiate)
        {
                //int i = Random.Range(0, platforms.Length);
                Instantiate(platforms[Random.Range(0, platforms.Length)], currPosition, platforms[0].transform.rotation, gameObject.transform);
				currPosition += new Vector3(Random.Range(-2, 4), Random.Range(-3, 2), Random.Range(6, 13));
		}
	}
}
