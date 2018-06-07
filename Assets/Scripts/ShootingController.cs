using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour {

    public Transform firePoint;
    public Transform bulletPrefab;
    public float bulletSpeed = 50f;

    void Update()
    {
        if (WantToShoot()) {
            Shoot();
        }
    }

    bool WantToShoot() {
        return Input.GetMouseButtonDown(0);
    }

    void Shoot() {
        Transform bullet = Instantiate(bulletPrefab);

        bullet.position = firePoint.position;
        bullet.rotation = firePoint.rotation;

        bullet.GetComponent<Rigidbody>().AddForce(firePoint.forward * bulletSpeed);

        Destroy(bullet.gameObject, 3f);
    }
}
