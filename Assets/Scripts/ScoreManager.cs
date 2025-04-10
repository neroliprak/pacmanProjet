using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    private int score = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Increments the number of collected coins
    public void AddScore(int amount)
    {
        score += amount;
    }

    // Returns the current score
    public int GetScore()
    {
        return score;
    }
}
