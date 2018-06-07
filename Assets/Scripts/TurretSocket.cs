using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretSocket : MonoBehaviour {
  public void SpawnTurret(GameObject turretPrefab) {
    GameObject turret = Instantiate(turretPrefab);
    turret.transform.position = transform.position;
  }
}
