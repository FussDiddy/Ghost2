using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelectorMenu : MonoBehaviour
{
    public static bool GamePaused = false;

    public Animator transition;

    public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
            {
                Resume();
            }

        }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("TempSceneChange");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
