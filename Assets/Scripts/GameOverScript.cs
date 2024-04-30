using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class GameOverScript : MonoBehaviour
{
    public AdsManager adsManager;
    public TMP_Text scoreText;
    public GameManager GameManager;
    public AdMobAdManager AdMobAdManager;
    public void SetUp(int score)
    {
        gameObject.SetActive(true);
        
        scoreText.text = score.ToString() + "Score";
    }
   
    public void RestartButton()
    {
        AdMobAdManager.LoadInterstitialAd();
        SceneManager.LoadScene("SpaceRunnerV2.0");
      
    }
    public void rewardAd()
    {
        Debug.Log("Button pressed");
        adsManager.ShowRewardAd();
    }
    public void MenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
