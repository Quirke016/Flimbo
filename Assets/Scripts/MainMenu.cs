using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("LevelTest");
    }
    public void LoadOptions()
    {
        SceneManager.LoadScene("Options");
    }
    public void NOYOUBITCH()
    {
        Debug.Log("The Game Would Have Exited: GAMEEXIT");
        Application.Quit();
    }
}
