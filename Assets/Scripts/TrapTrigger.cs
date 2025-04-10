using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TrapTrigger : MonoBehaviour
{
    private const string PLAYER_TAG = "Player";

    public RawImage filterTrapVideo;
    public float duration = 4f;

    private void Start()
    {
        if (filterTrapVideo == null)
        {
            Debug.LogError("filterTrapVideo n'existe pas");
            return;
        }
        filterTrapVideo.enabled = false;
    }

    // When the player enters the trigger, a video filter is enabled.
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(PLAYER_TAG))
        {
            filterTrapVideo.enabled = true;
            StartCoroutine(RemoveFilterAfterDelay());
        }
    }
    // Coroutine to disable the filter after a delay
    private IEnumerator RemoveFilterAfterDelay()
    {
        yield return new WaitForSeconds(duration);
        filterTrapVideo.enabled = false;
    }
}
