using UnityEngine;
using UnityEngine.UI;

public class TrapTrigger : MonoBehaviour
{
    private const string PLAYER_TAG = "Player";

    public RawImage filterTrapVideo;

    private void Start()
    {
        if (filterTrapVideo == null)
        {
            Debug.LogError("filterTrapVideo n'existe pas");
            return;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(PLAYER_TAG))
        {
            Debug.Log("Entré dans la plaque");

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(PLAYER_TAG))
        {
            Debug.Log("Sortie de la plaque");

        }
    }

}
