using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timers = 0f;
    public Text timerText;

    void Start()
    {
        timers = 0;
        UpdateTimerUI();
    }

    void Update()
    {
        timers += Time.deltaTime;
        UpdateTimerUI();
    }

    private void UpdateTimerUI()
    {
        if (timerText != null)
        {
            timerText.text = "Temps : " + timers.ToString("F2") + "s";
        }
        else
        {
            Debug.LogWarning("");
        }
    }
}
