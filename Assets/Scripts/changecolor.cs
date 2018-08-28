using System;
using System.Collections;
using UnityEngine;
public class changecolor : MonoBehaviour
{
	void Start()
    {

    }
    void Update()
    {
        gameObject.GetComponent<MeshRenderer>().materials[0].color = Color.red;
    }
}
