using UnityEngine;
using UnityEngine.UI;

public class DropMoney : MonoBehaviour
{
    private const string PLAYER_TAG = "Player";
    [SerializeField] private int money = 1;
    [SerializeField] private Text scoreText;

    // Reference to the GameCondition.cs class
    private GameCondition gameCondition;

    private void Start()
    {
        gameCondition = FindObjectOfType<GameCondition>();
    }

    // The player gets a coin
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(PLAYER_TAG))
        {
            HandleMoney();
        }
    }

    // Handles the money collection events
    private void HandleMoney()
    {

        // Adds score to the previous score
        ScoreManager.Instance.AddScore(money);
        // Disables the money object
        gameObject.SetActive(false);

        UpdateScoreText();
        if (gameCondition != null)
        {
            // Checks if the player has collected all coins
            gameCondition.CollectCoin();
        }
    }

    // Update the score in Canva
    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + ScoreManager.Instance.GetScore();
        }
    }
}
