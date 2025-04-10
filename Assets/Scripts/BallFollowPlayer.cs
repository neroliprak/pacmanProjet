using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFollowPlayer : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    // Reference to the GameCondition.cs class
    private GameCondition gameCondition;
    private Transform playerTransform;
    private const string PLAYER_TAG = "Player";

    // Get position of player
    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag(PLAYER_TAG);
        if (player != null)
        {
            playerTransform = player.transform;
        }
        gameCondition = FindObjectOfType<GameCondition>();
    }

    void Update()
    {
        if (playerTransform != null)
        {
            MoveTowardsPlayer();
        }
    }

    // Move to the player's position with delays
    private void MoveTowardsPlayer()
    {
        Vector3 direction = (playerTransform.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }

    // Detection of a collision with the player
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(PLAYER_TAG))
        {
            HandlePlayerCollision();
        }
    }

    // Removes health points from the player after collision
    private void HandlePlayerCollision()
    {
        if (gameCondition != null)
        {
            gameCondition.TakeDamage(1);
        }

    }
}