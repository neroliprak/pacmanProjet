using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageByEnemies : MonoBehaviour
{
    private GameCondition gameCondition;
    private const string PLAYER_TAG = "Player";

    void Start()
    {
        gameCondition = FindObjectOfType<GameCondition>();
    }

    // When the enemy collides with the player, decrease health points
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(PLAYER_TAG))
        {
            HandlePlayerCollision();
        }
    }

    private void HandlePlayerCollision()
    {
        if (gameCondition != null)
        {
            gameCondition.TakeDamage(1);
        }
    }
}
