using UnityEngine;

public class DropMoney : MonoBehaviour
{
    private const string PLAYER_TAG = "Player";
    public int money = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(PLAYER_TAG))
        {

            ScoreManager.Instance.AddScore(money);

            gameObject.SetActive(false);

            Debug.Log("Score actuel : " + ScoreManager.Instance.GetScore());
        }
    }
}
