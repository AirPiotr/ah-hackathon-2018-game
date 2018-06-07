using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Rigidbody rigidbody;
    public float jumpForce = 5f;
    public float movementSpeed = 150f;
    public float rotationSpeed = 3f;

	void Start() {
        rigidbody = GetComponentInChildren<Rigidbody>();		
	}

	// Update is called once per frame
	void Update () {
        Move();

        if (Input.GetKeyDown(KeyCode.Space)) {
            Jump(); 
        }
    }

    void Move() {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * rotationSpeed;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }

    void Jump() {
        rigidbody.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
    }
}
