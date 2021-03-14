using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    DateTime lastTick;
    TimeSpan tickInterval;


    public Text timeRemaining;

    private void Update()
    {
        if (Data.Instance.gameIsPaused == false)
        {
            tickInterval = DateTime.Now - lastTick;
            if (tickInterval.Seconds > 1 && Data.Instance.playTime != 0)
            {
                Data.Instance.playTime--;
                lastTick = DateTime.Now;
            }
            if (Data.Instance.playTime == 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
