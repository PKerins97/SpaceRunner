using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public AdMobAdManager adMobAdManager;
    public playGamesManager playGamesManager;
    public void playGame()
    {
        SceneManager.LoadScene("SpaceRunnerV2.0");
    }
    public void rewardAd()
    {
        Debug.Log("Button pressed");
        adMobAdManager.LoadReward();
    }
    public void quitGame()
    {
        Application.Quit();
    }

 
}
