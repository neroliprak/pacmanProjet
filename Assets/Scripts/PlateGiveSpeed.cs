using StarterAssets;
using UnityEngine;
using System.Collections;

public class PlateGiveSpeed : MonoBehaviour
{
    [SerializeField] private float boostSpeed = 8.0f;
    [SerializeField] private float boostDuration = 3.0f;

    private const string PLAYER_TAG = "Player";

    // In contact with the plate, gives speed to the player
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(PLAYER_TAG))
        {
            FirstPersonController controller = other.GetComponent<FirstPersonController>();

            if (controller != null)
            {
                // Start the coroutine to apply the temporary speed
                StartCoroutine(DurationSpeed(controller));
            }
        }
    }

    // Coroutine, which modifies the player's speed for a specific period of time
    private IEnumerator DurationSpeed(FirstPersonController controller)
    {
        float originalSpeed = controller.MoveSpeed;

        controller.MoveSpeed = boostSpeed;

        // Wait for maximum speed duration
        yield return new WaitForSeconds(boostDuration);

        controller.MoveSpeed = originalSpeed;

    }
}
