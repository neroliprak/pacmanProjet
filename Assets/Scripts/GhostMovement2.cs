using UnityEngine;

public class GhostMovement2 : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private Transform[] patrolWaypoints;
    [SerializeField] private Transform player;
    [SerializeField] private float chaseDistance = 5f;

    private int currentWaypoint = 0;
    private bool isChasing = false;

    private const float stopHuntDistance = 1.2f;

    void Update()
    {
        if (player != null)
        {
            HandleChasingBehavior();
            MoveGhost();
        }
    }

    // Manages player detection and changes the hunting state
    private void HandleChasingBehavior()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // If the player is within hunting range
        isChasing = distanceToPlayer < chaseDistance;

        // If the player moves too far away, stop the hunt
        if (isChasing && distanceToPlayer > chaseDistance * stopHuntDistance)
        {
            isChasing = false;
        }
    }

    // Move the ghost according to its state (pursuit or patrol)
    private void MoveGhost()
    {
        if (isChasing)
        {
            ChasePlayer();
        }
        else
        {
            Patrol();
        }
    }

    // Move the ghost towards the player
    private void ChasePlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }

    // Patrol behaviour between defined waypoints
    private void Patrol()
    {
        if (patrolWaypoints.Length == 0) return;

        Vector3 targetPosition = patrolWaypoints[currentWaypoint].position;
        MoveTowards(targetPosition);

        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            currentWaypoint = (currentWaypoint + 1) % patrolWaypoints.Length;
        }
    }


    private void MoveTowards(Vector3 targetPosition)
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }


}
