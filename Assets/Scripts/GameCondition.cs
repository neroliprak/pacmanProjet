using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameCondition : MonoBehaviour
{
    [SerializeField] private int totalCoins = 1;
    private int collectedCoins = 0;
    [SerializeField] private int maxLives = 3;
    private int currentLives;
    [SerializeField] private Text livesText;

    private const string VICTORY_SCENE = "VictoryScene";
    private const string DEFEAT_SCENE = "DefeatScene";

    private void Start()
    {
        LifePoints();
        UpdateLivesText();
    }

    // Handle the coin collection logic
    public void CollectCoin()
    {
        // Increment the number of collected coins by player
        collectedCoins++;
        // Check if all coins have been collected
        if (collectedCoins >= totalCoins)
        {
            WinGame();
        }
    }

    // Updates the player damage from enemies and determines whether he has any hit points left
    public void TakeDamage(int damage)
    {
        currentLives -= damage;
        UpdateLivesText();

        if (currentLives <= 0)
        {
            LoseGame();
        }
    }

    // Update the lives in Canva
    private void UpdateLivesText()
    {
        if (livesText != null)
        {
            livesText.text = "Lives : " + currentLives;
        }
    }

    // Check if the player has collected all coins 
    public void CheckVictory()
    {
        if (collectedCoins >= totalCoins)
        {
            WinGame();
        }
    }

    // Handles the game over to the Victory scene
    private void WinGame()
    {
        SceneManager.LoadScene(VICTORY_SCENE);
    }

    // Handles the game over to the Defeat scene
    private void LoseGame()
    {
        SceneManager.LoadScene(DEFEAT_SCENE);
    }

    // Adds maximum health points
    private void LifePoints()
    {
        currentLives = maxLives;
    }
}