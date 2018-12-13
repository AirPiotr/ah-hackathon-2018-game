using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
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
        float speed = Time.deltaTime * stats.GetSpeed();
        float forwardForce = Input.GetAxis("Vertical") * speed;
        float sideForce = Input.GetAxis("Horizontal") * speed;

        transform.Translate(sideForce, 0, forwardForce);

    }
}
