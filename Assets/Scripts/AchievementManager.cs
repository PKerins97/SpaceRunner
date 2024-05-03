using GooglePlayGames;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementManager : MonoBehaviour
{

    public void GrantAchievement(string _achivementID)
    {
        PlayGamesPlatform.Instance.ReportProgress(_achivementID, 100.0f, (bool success) =>
        {
            if (success)
            {
                Debug.Log("Achievement Unlocked");
            }
            else
            {
                Debug.Log("Achievement Unlock Failed");
            }
        });
    }
}
