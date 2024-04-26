using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public AdsManager adsManager;
    public Text scoreText;
    public void SetUp(int score)
    {
        gameObject.SetActive(true);
        
        //scoreText.text = score.ToString() + "Score";
    }
   
    public void RestartButton()
    {
        SceneManager.LoadScene("SpaceRunnerV2.0");
      
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
