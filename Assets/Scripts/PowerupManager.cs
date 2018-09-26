using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupManager : MonoBehaviour {

	public GameObject[] powerUps;

	// Use this for initialization
	void Start () {
		int chance = Random.Range (1, 100);
		if (chance >= 65) {
			int i = Random.Range (0, powerUps.Length);
			powerUps [i].SetActive (true);
		}
	}
}
