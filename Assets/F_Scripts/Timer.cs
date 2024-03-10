using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private float totalTime = 180.0f; // Total countdown time in seconds
    private float currentTime; // Current remaining time

    public TextMeshProUGUI timerText; // Reference to the UI Text element

    // Start is called before the first frame update
    void Start()
    {
        // Set initial time
        currentTime = totalTime;
    }

    // Update is called once per frame
    void Update()
    {
        // Update current time
        currentTime -= Time.deltaTime;

        // Clamp current time to avoid negative values
        if (currentTime < 0)
        {
            currentTime = 0;
            SceneManager.LoadScene("MainMenu");
        }

        // Calculate minutes and seconds
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);

        // Update UI text with formatted time
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
