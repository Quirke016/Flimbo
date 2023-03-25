using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUi;
    public GameObject optionsMenuUi;
    public static bool gameIsPaused = false;
    public Death dead;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !dead)
        {
            if (gameIsPaused)
            {
                Resume();
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
            else
            {
                Pause();
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }
    public void Resume()
    {
        pauseMenuUi.SetActive(false);
        optionsMenuUi.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Pause()
    {
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main");
    }

    public void LoadOptions()
    {
        pauseMenuUi.SetActive(false);
        optionsMenuUi.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void UnStuckButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("LevelTest");
        Resume();
    }

}
