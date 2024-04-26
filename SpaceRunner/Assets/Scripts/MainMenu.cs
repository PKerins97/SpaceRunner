using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AdsManager adsManager;
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void rewardAd()
    {
        IronSource.Agent.loadRewardedVideo();
    }
    public void quitGame()
    {
        Application.Quit();
    }


}
