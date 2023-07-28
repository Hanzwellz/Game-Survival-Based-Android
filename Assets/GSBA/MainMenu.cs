using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StageMenu()
    {
        SceneManager.LoadScene("Stage Menu");
    }

    public void GoToSettingsMenu()
    {
        SceneManager.LoadScene("SettingsMenu");
    }

    public void GoToStoryMenu()
    {
        SceneManager.LoadScene("StoryMenu");
    }

    public void GoToAboutMenu()
    {
        SceneManager.LoadScene("AboutMenu");
    }

    public void GoToObjectiveMenu()
    {
        SceneManager.LoadScene("ObjectiveMenu");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {

        Application.Quit();
    }
}
