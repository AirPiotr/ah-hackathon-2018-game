using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : Stats
{
    public delegate void onStatsChangedCallback();
    public onStatsChangedCallback onStatsChanged;

    public Weapon weapon = Weapon.regular;

    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);

        SubscribeChange();
    }

    void SubscribeChange()
    {
        if (onStatsChanged != null) {
            onStatsChanged.Invoke();
        }
    }

    public void SwitchWeapon() {
        switch(weapon) {
            case Weapon.heavy:
                weapon = Weapon.regular;
                break;
            case Weapon.regular:
                weapon = Weapon.heavy;
                break;
        }

        SubscribeChange();
    }
}

public enum Weapon { regular, heavy };