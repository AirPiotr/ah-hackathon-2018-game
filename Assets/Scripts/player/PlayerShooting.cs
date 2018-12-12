using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : ShootingController {

	void Start () {
        stats = GetComponent<PlayerStats>();

        if (stats.GetType() != typeof(PlayerStats)) {
            Debug.LogError("Stats must be PlayerStats instance!");
        }
	}

    protected override bool WantToShoot() {
        return Input.GetMouseButtonDown(0);
	}

	protected override void ChangeCallback() {
        ((PlayerStats)stats).SubscribeChange();
	}
}
