using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : Stats {
    public delegate void onStatsChangedCallback();
    public onStatsChangedCallback onStatsChanged;

    public override void TakeDamage(float damage) {
        base.TakeDamage(damage);

        SubscribeChange();
    }

    void SubscribeChange() {
        if (onStatsChanged != null) {
            onStatsChanged.Invoke();
        }
    }
}
