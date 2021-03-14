using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //public bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public float speed;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Data.Instance.gameIsPaused)
            {
                GameResume();
            }
            else
            {
                GamePause();
            }
        }
        Time.timeScale = 1f;
    }

    public void GameResume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Data.Instance.gameIsPaused = false;
    }

    void GamePause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Data.Instance.gameIsPaused = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
        Data.Instance.score = 0;
    }


}
