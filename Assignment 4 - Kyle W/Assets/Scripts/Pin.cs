using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pin : MonoBehaviour
{
    private DateTime lastLoss;
    private TimeSpan hitInterval;
    private bool isPinned = false;

    public float speed;
    public Rigidbody2D rb;

    void Update()
    {
        if (!isPinned)
        {
            //rb.position is being used since it will return a 2D vector.
            //While a transform will give us a 3d vector and we don't need that.
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
            hitInterval = DateTime.Now - lastLoss;
        }

        if (Data.Instance.gameIsPaused)
        {
            speed = 0f;
        }
        else
        {
            speed = 20f * Data.Instance.pinSpeed * Time.timeScale;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Rotator")
        {
            //When the object (pin) hits the parent object (rotator) the pin rotates like the rotator does.
            transform.SetParent(col.transform);

            Data.Instance.score++;

            //Added Difficulty.
            //When a pin hits the rotator it speeds up by 50.
            //col.GetComponent<Rotater>().speed += 50f;

            //When a pin hits the rotator it spins the opposite direction.
            //col.GetComponent<Rotater>().speed *= -1;

            isPinned = true;
        }
        else if (col.tag == "Pin")
        {
            if (Data.Instance.playerLives > 0 && hitInterval.Seconds >.1 && !isPinned)
            {
                this.isPinned = true;
                lastLoss = DateTime.Now;
                Data.Instance.playerLives -= 1;
                FindObjectOfType<GameManager>().EndGame();
            }
            if (Data.Instance.playerLives == 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }

    }
}
