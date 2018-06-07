using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : Stats
{
    public delegate void onStatsChangedCallback();
    public onStatsChangedCallback onStatsChanged;
    public PrefabsManager prefabsManager;

    void Start() {
        prefabsManager = PrefabsManager.instance;

        currentWeapon = prefabsManager.regularWeapon;

        SubscribeChange();
    }

    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);

        SubscribeChange();
    }

    public void SwitchWeapon() {
        switch(currentWeapon.type) {
            case WeaponType.heavy:
                currentWeapon = prefabsManager.regularWeapon;
                break;
            case WeaponType.regular:
                currentWeapon = prefabsManager.heavyWeapon;
                break;
        }

        SubscribeChange();
    }

    public void SubscribeChange() {
        if (onStatsChanged != null)
        {
            onStatsChanged.Invoke();
        }
    }
}

