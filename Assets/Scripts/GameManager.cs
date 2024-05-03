using TMPro;
using UnityEngine;
using UnityEngine.UI;
using GooglePlayGames;
using GooglePlayGames.BasicApi;

public class GameManager : MonoBehaviour
{
    
    public SpaceRunner spaceRunner; // Reference to the SpaceRunnerGame script
    public AdsManager adsManager;
    public AdMobAdManager AdMobAdManager;
    public GameOverScript GameOverScript;
    public TMP_Text scoreText; // UI text for displaying score
    public TMP_Text coinsText; // UI text for displaying coins
    private int score = 0; // Player's score
    private int coins = 0; // Player's coins
    private bool isGameOver = false;
    public Transform player;
    
    public LeaderboardManager leaderboardManager;
    void Start()
    {
        // Initialize the game
        isGameOver = false;


      score = 0; 
     coins = 0; 


}
     void Update()
    {
      

    }
    // Method to handle game over
    public void GameOver()
    {

        if (!isGameOver)
        {
            Debug.Log("Game Over");
            Debug.Log(score + " Reported to leaderboard");
            GameOverScript.SetUp();
            AdMobAdManager.LoadInterstitial();
            
        }
        AdMobAdManager.LoadBanner();
        
    }


    // Method to update the player's score
    public void UpdateScore(int points)
    {
        score += points;
        // Update UI to reflect the new score
        scoreText.text = "Score: " + score.ToString();
    }

}