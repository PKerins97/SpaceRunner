using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AdMobAdManager adMobAdManager;
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void rewardAd()
    {
        Debug.Log("Button pressed");
        adMobAdManager.LoadRewardedAd();
        adMobAdManager.ShowRewardedAd();
    }
    public void quitGame()
    {
        Application.Quit();
    }


}
