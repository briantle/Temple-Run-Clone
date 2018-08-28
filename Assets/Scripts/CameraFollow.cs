﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform playerTransform;
	private Vector3 startOffset;

	// Use this for initialization
	void Start () {
		playerTransform = GameObject.FindGameObjectWithTag ("Player").transform;
		startOffset = transform.position - playerTransform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = playerTransform.position + startOffset;
	}
}
