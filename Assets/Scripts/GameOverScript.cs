using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class GameOverScript : MonoBehaviour
{
    public AdsManager adsManager;
    
    public GameManager GameManager;
    public AdMobAdManager AdMobAdManager;
    public SpaceRunner spacerunner;
    
    public void SetUp()
    {
        gameObject.SetActive(true);

    }
   
    public void RestartButton()
    {
        
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
