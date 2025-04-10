using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private float timers = 0f;
    [SerializeField] private Text timerText;

    void Start()
    {
        timers = 0;
        UpdateTimerText();
    }

    // Per frame to update the timer
    void Update()
    {
        timers += Time.deltaTime;
        UpdateTimerText();
    }

    // Update the timer text in UI
    private void UpdateTimerText()
    {
        if (timerText != null)
        {
            // Formatted time value
            timerText.text = "Temps : " + timers.ToString("F2") + "s";
        }
    }
}
