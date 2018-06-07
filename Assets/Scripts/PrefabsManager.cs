using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabsManager : MonoBehaviour {

    public static PrefabsManager instance;

    [HideInInspector] public Weapon heavyWeapon;
    [HideInInspector] public Weapon regularWeapon;

    public Transform heavyWeaponPrefab;
    public Transform regularWeaponPrefab;

    void Awake() {
        instance = this;

        heavyWeapon = new Weapon(30, WeaponType.heavy, heavyWeaponPrefab);
        regularWeapon = new Weapon(int.MaxValue, WeaponType.regular, regularWeaponPrefab, true);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
