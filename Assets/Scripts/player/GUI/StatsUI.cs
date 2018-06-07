using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class StatsUI : MonoBehaviour {

    public PlayerStats stats;
    public RectTransform currentHealth;

    private Vector2 currentHealthStartPos;

	void Start () {
        currentHealthStartPos = currentHealth.sizeDelta;

        stats.onStatsChanged += UpdateUI;
	}
	
    void UpdateUI () {
        currentHealth.sizeDelta = new Vector2(
            stats.currentHealth / stats.maxHealth * currentHealthStartPos.x,
            currentHealthStartPos.y
        );
	}
}
