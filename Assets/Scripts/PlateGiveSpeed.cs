using StarterAssets;
using UnityEngine;
using System.Collections;

public class PlateGiveSpeed : MonoBehaviour
{
    public float newSpeed = 8.0f;
    public float speedDuration = 3.0f;

    private const string PLAYER_TAG = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(PLAYER_TAG))
        {
            FirstPersonController controller = other.GetComponent<FirstPersonController>();

            if (controller != null)
            {
                StartCoroutine(DurationSpeed(controller));
            }
        }
    }

    private IEnumerator DurationSpeed(FirstPersonController controller)
    {
        float originalSpeed = controller.MoveSpeed;

        controller.MoveSpeed = newSpeed;
        // Debug.Log("Vitesse " + newSpeed);

        yield return new WaitForSeconds(speedDuration);

        controller.MoveSpeed = originalSpeed;
        // Debug.Log("Vitesse" + originalSpeed);
    }
}
