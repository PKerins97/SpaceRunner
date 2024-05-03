using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using TMPro;
using UnityEngine.SocialPlatforms;

public class playGamesManager : MonoBehaviour
{
    public TextMeshProUGUI DetailsTexts;

    // Start is called before the first frame update
    void Start()
    {
        SignIn();
    }

 public void SignIn()
    {
        PlayGamesPlatform.Instance.Authenticate(ProcessAuthentication);
    }
    internal void ProcessAuthentication(SignInStatus status)
    {
        if (status == SignInStatus.Success)
        {
            // Continue with Play Games Services
            string name = PlayGamesPlatform.Instance.GetUserDisplayName();


            DetailsTexts.text = "Welcome \n " + name ;
        }
        else
        {
            DetailsTexts.text = "Sign In Fail";
            // Disable your integration with Play Games Services or show a login button
            // to ask users to sign-in. Clicking it should call
            // PlayGamesPlatform.Instance.ManuallyAuthenticate(ProcessAuthentication).
        }
    }

    public void ShowAchievementsUI()
    {
        PlayGamesPlatform.Instance.ShowAchievementsUI();
    }

    public void ShowLeaderBoardUI()
    {
        PlayGamesPlatform.Instance.ShowLeaderboardUI();
    }
}
