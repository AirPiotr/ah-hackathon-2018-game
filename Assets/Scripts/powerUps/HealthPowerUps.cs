using UnityEngine;

public class HealthPowerUps : Collectable {
    public int healValue = 20;

    protected override void Interact(GameObject gameObject) {
        PlayerStats stats = gameObject.GetComponent<PlayerStats>();

        stats.Heal(healValue);
        Destroy(this.gameObject);
    }
}
