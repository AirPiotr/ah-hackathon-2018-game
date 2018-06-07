using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {
  public TurretSpawner turretSpawner;
  
	// Use this for initialization
	void Start () {
		turretSpawner.Spawn();
	}
}
