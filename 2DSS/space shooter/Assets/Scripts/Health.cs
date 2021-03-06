using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public class PlayerStats {
        public int Health = 100;
    }

    public PlayerStats playerStats = new PlayerStats();

    void OnTriggerEnter2D (Collider2D hitInfo) {
        if(GameObject.FindGameObjectWithTag("Enemy") == true) {
        Debug.Log(hitInfo.name);
        DamagePlayer(50);
        }
    }

    public void DamagePlayer (int damage) {
        playerStats.Health -= damage;
        if (playerStats.Health <= 0) {
            GameMaster.KillPlayer(this);
            Debug.Log ("KILL PLAYER");
        }
    }
}
