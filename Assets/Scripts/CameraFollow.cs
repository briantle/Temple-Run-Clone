using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform playerTransform;
	private Vector3 offset;
	private Vector3 moveVector;

	// Use this for initialization
	void Start () {
		playerTransform = GameObject.FindGameObjectWithTag ("Player").transform;
		offset = transform.position - playerTransform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = playerTransform.position + offset;
	}
}
