using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    
    public float movementSpeed = 15f;

    private Rigidbody rigidbody;

	void Start() {
        rigidbody = GetComponentInChildren<Rigidbody>();
	}

	// Update is called once per frame
    void Update () {
        Move();
    }

    void Move() {
        float z = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;

        transform.Translate(0, 0, z);
    }
}
