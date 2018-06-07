using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TurretSpawner : MonoBehaviour {
  public GameObject[] turretPrefabs;
  protected List<TurretSocket> turretSockets;
 
	void Awake() {
    turretSockets = GameObject.FindObjectsOfType<TurretSocket>().ToList();
	}
	
	public void Spawn () {
		turretSockets.ForEach(socket => socket.SpawnTurret(turretPrefabs[0]));
	}
}
