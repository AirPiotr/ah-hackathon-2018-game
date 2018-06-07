using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour {

    [HideInInspector] public float currentHealth;
    public float maxHealth = 100;

    public Weapon currentWeapon;

    void Awake() {
        currentHealth = maxHealth;
    }

    public virtual void TakeDamage(float damage) {
        currentHealth -= damage;

        if (currentHealth <= maxHealth) {
            Die();
        }
    }

    public void Die() {
        // TODO: die somehow
    }
}
