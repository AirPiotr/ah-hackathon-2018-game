using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShootingController : MonoBehaviour
{

    public Transform firePoint;
    public float bulletSpeed = 50f;
    public Stats stats;

    void Update()
    {
        if (WantToShoot())
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Weapon weapon = stats.currentWeapon;

        if (weapon.ammo <= 0)
        {
            return;
        }

        Transform bullet = Instantiate(weapon.prefab);

        bullet.position = firePoint.position;
        bullet.rotation = firePoint.rotation;

        bullet.GetComponent<Rigidbody>().AddForce(firePoint.forward * bulletSpeed);

        weapon.Use();

        Destroy(bullet.gameObject, 3f);

        ChangeCallback();
    }

    protected abstract bool WantToShoot();

    protected abstract void ChangeCallback();
}
