using UnityEngine.UI;
using UnityEngine;

public class WeaponUI : MonoBehaviour {

    public PlayerStats stats;
    public Text type;
    public Text ammo;

	void Start () {
        stats.onStatsChanged += UpdateUI;
	}
	
	void UpdateUI () {
        Weapon weapon = stats.currentWeapon;

        switch(weapon.type) {
            case WeaponType.regular:
                type.text = "Regular";
                break;
            case WeaponType.heavy:
                type.text = "Heavy";
                break;
        }

        if (weapon.infinityAmmo) {
            ammo.text = "Infinity";
        } else {
            ammo.text = weapon.ammo + "";    
        }

	}
}
