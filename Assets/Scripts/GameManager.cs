using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText; // UI text for displaying score
    //public GameObject gameOverPanel; // UI panel for displaying game over
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
        UpdateScore(0);
        AdMobAdManager.LoadBannerAd();
        

    }

    // Method to handle game over
    public void GameOver()
    {

        if (!isGameOver)
        {
            Debug.Log("Game Over");
            AdMobAdManager.LoadInterstitialAd();
            GameOverScript.SetUp(score);

        }
        
    }


    // Method to update the player's score
    public void UpdateScore(int points)
    {
        score += points;
        // Update UI to reflect the new score
        scoreText.text = "Score: " + score;
    }

}