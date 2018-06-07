using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon {

    public WeaponType type;
    public int ammo;
    public Transform prefab;
    public bool infinityAmmo;

    public Weapon(int ammo, WeaponType type, Transform prefab, bool infinityAmmo = false) {
        this.ammo = ammo;
        this.type = type;
        this.prefab = prefab;
        this.infinityAmmo = infinityAmmo;
    }

    public void Use() {
        if (!infinityAmmo) {
            ammo--;
        }
    }

}

public enum WeaponType { regular, heavy };