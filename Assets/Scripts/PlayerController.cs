﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    void Update () {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * 150f;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * 3f;

        Debug.Log(x);

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }
}
