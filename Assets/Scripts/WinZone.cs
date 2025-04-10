using UnityEngine;
using UnityEngine.SceneManagement;

public class WinZone : MonoBehaviour
{
    private const string PLAYER_TAG = "Player";
    private const string VICTORY_SCENE = "VictoryScene";

    // When the player enters the green zone(exit)
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(PLAYER_TAG))
        {
            SceneManager.LoadScene(VICTORY_SCENE);
        }
    }
}
