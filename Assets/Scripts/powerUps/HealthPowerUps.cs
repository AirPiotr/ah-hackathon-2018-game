using UnityEngine;

public class HealthPowerUps : MonoBehaviour {
    public int healValue = 20;

    private bool collided = false;
	
    void OnCollisionEnter (Collision col) {
        if (col.gameObject.tag == "Player" && !collided) {
            PlayerStats stats = col.gameObject.GetComponent<PlayerStats>();

            stats.Heal(healValue);

            collided = true;
            Destroy(gameObject);
        }
    }
}
