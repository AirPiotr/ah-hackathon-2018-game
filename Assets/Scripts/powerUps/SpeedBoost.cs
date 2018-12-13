using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : Boost {

    protected override void Interact(GameObject gameObject) {
        PlayerStats stats = gameObject.GetComponent<PlayerStats>();

        stats.speedBoost += boostValue;
        StartCoroutine(ClearBoost(stats));
	}

    private IEnumerator ClearBoost(PlayerStats stats) {
        yield return new WaitForSeconds(boostTime);

        stats.speedBoost -= boostValue;
        Destroy(this.gameObject);
    }
}
