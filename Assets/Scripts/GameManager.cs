using TMPro;
using UnityEngine;
using UnityEngine.UI;
using GooglePlayGames;
using GooglePlayGames.BasicApi;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText; // UI text for displaying score
    public SpaceRunner spaceRunner; // Reference to the SpaceRunnerGame script
    public AdsManager adsManager;
    public AdMobAdManager AdMobAdManager;
    public GameOverScript GameOverScript;
    private int score = 0;
    private bool isGameOver = false;
    public Transform player;
    void Start()
    {
        // Initialize the game
        isGameOver = false;
        UpdateScore(score);
        
        

    }

    // Method to handle game over
    public void GameOver()
    {

        if (!isGameOver)
        {
            Debug.Log("Game Over");
            GameOverScript.SetUp(score);
            AdMobAdManager.LoadInterstitial();
        }
        AdMobAdManager.LoadBanner();
    }


    // Method to update the player's score
    public void UpdateScore(int points)
    {
        score += points;
        // Update UI to reflect the new score
        scoreText.text = "Score: " + score;
    }

}