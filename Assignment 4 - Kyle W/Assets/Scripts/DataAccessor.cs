using UnityEngine;
using UnityEngine.UI;

public class DataAccessor : MonoBehaviour
{
    //Allows you to access the Data Instance for Game and End scenes.
    public Text playerLives;

    //public Text rotationSpeed;

    //public Text pinSpeed;

    public Text playTime;

    public Text playerName;

    public Text score;



    // Update is called once per frame
    void Update()
    {
        playerName.text = "" + Data.Instance.playerName;
        playerLives.text = "Lives: " + Data.Instance.playerLives;
        playTime.text = "Time Left: " + Data.Instance.playTime;
        score.text = "" + Data.Instance.score;
    }
}
