using System;
using UnityEngine;
using UnityEngine.UI;

public class DataStorage : MonoBehaviour
{
    //MainMenu Storage

    public InputField playerName;

    public Dropdown playerLives;

    public Slider rotationSpeed;

    public Slider pinSpeed;

    public Dropdown playTime;

    public void Update()
    {
        Data.Instance.rotationSpeed = rotationSpeed.value;
        Data.Instance.pinSpeed = pinSpeed.value;
        Data.Instance.playerName = playerName.text;
        switch (playerLives.value)
        {
            default:
                Data.Instance.playerLives = 2;
                break;
            case 1:
                Data.Instance.playerLives = 2;
                break;
            case 2:
                Data.Instance.playerLives = 3;
                break;
            case 3:
                Data.Instance.playerLives = 4;
                break;
        }

        Data.Instance.playTime = playTime.value;
        switch (playTime.value)
        {
            default:
                Data.Instance.playTime = 15;
                break;
            case 1:
                Data.Instance.playTime = 15;
                break;
            case 2:
                Data.Instance.playTime = 20;
                break;
            case 3:
                Data.Instance.playTime = 25;
                break;
        }
    }
}