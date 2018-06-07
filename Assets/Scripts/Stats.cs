using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour {

    public int currentHealth;
    public int maxHealth = 100;

    void Awake() {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage) {
        currentHealth -= damage;

        if (currentHealth <= maxHealth) {
            Die();
        }
    }

    public void Die() {
        // TODO: die somehow
    }
}
