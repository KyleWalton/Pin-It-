using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Data : MonoBehaviour
{
    //Stores data and persists
    public static Data Instance { get; private set; }

    public string playerName;

    public int playerLives;

    public float rotationSpeed;

    public float pinSpeed;

    public int playTime;

    public int score = 0;

    public bool gameIsPaused;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
