using System;
using System.Collections;
using UnityEngine;

public class StepOnPlatform : MonoBehaviour
{
	void OnControllerColliderHit(ControllerColliderHit hit){
		if (hit.gameObject.tag == "Platform")
			hit.gameObject.GetComponent<DestroyAtDistance>().steppedOn = true;
	}
}