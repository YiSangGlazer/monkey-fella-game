using UnityEngine;
using TMPro; // Required for TextMeshPro UI elements 
using System;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance; // Singleton pattern to easily reference the manager 

    public TextMeshProUGUI scoreText; // Reference to the UI Text object 
    public TextMeshProUGUI timerText; // Optional: Reference to a separate UI Text for the timer 

    private float totalScore;
    private float elapsedTime;
    private int bananasCollected;

    // Adjust these values in the Inspector to balance your game 
    public float pointsPerBanana = 10f;
    public float pointsPerSecond = 1f;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        totalScore = 0;
        bananasCollected = 0;
        elapsedTime = 0;
        UpdateScoreDisplay();
    }

    void Update()
    {
        // Increment elapsed time every frame 
        elapsedTime += Time.deltaTime;

        // Update the score based on time (if desired to update in real-time) 
        // A better approach might be to calculate the final score at the end of the game 

        UpdateScoreDisplay(); // Update UI constantly 
    }

    public void AddBanana()
    {
        bananasCollected++;
        // Immediately update score for collecting a banana 
        totalScore += pointsPerBanana;
        UpdateScoreDisplay();
    }

    public void UpdateScoreDisplay()
    {
        // Calculate the score based on time (e.g., points awarded for faster time) 
        // Example: Less time = higher score (inverse relationship) 

        // For simplicity here, the score is calculated based on bananas collected * value 
        // The total score can be a combination when the game ends. 

        if (scoreText != null)
        {
            // The score displayed during the game is usually just the collected items 
            scoreText.text = "Bananas: " + bananasCollected.ToString();
        }

        if (timerText != null)
        {
            // Display time in a readable format (minutes:seconds) 
            TimeSpan timeSpan = TimeSpan.FromSeconds(elapsedTime);
            timerText.text = string.Format("{0:D2}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds);
        }
    }

    // Function to calculate final score when the game ends 
    public float CalculateFinalScore()
    {
        // The final score considers both collections and time 
        // Example: 10 points per banana minus 1 point for every 2 seconds taken 
        // You can define your own formula 
        float finalScore = (bananasCollected * pointsPerBanana) + (pointsPerSecond * elapsedTime);
        return finalScore;
    }
}
