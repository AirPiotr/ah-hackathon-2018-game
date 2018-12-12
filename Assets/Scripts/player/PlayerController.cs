using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    
    public float movementSpeed = 5f;
    private PlayerStats stats;

    void Start() {
        stats = GetComponent<PlayerStats>();
    }

    void Update () {
        Move();

        if (Input.GetKeyDown(KeyCode.Tab)) {
            stats.SwitchWeapon();
        }
    }

    void Move() {
        float forwardForce = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
        float sideForce = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;

        transform.Translate(sideForce, 0, forwardForce);

    }
}
