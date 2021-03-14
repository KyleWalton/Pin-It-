using System;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    //Around 1/3 or 1/4 rotation per second.
    public float speed;

    private void Update()
    {
        if (Data.Instance.gameIsPaused)
        {
            speed = 0f;
        }
        else
        {
            speed = 100f * Data.Instance.pinSpeed * Time.timeScale;
        }
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }
}
