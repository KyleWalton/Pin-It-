using System;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pinPrefab;

    private void Update()
    {
        if (Data.Instance.gameIsPaused == true)
        {
            //Debug.Log("No fire game is paused.");
        }

        if (Input.GetButtonDown("Fire1") && Data.Instance.gameIsPaused == false)
        {
            SpawnPin();
        }

        void SpawnPin()
        {
            Instantiate(pinPrefab, transform.position, transform.rotation);
        }
    }
}
