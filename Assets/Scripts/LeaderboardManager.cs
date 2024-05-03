using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;

public class LeaderboardManager : MonoBehaviour
{


    

    public void ReportScore(string leaderboard_id, int score)
    {
        PlayGamesPlatform.Instance.ReportScore(score,leaderboard_id, (bool success) =>
        {
            if (success)
            {
                Debug.Log("Score posted");
            }
            else
            {
                Debug.Log("Score was not posted");
            }
        });
    }
}
