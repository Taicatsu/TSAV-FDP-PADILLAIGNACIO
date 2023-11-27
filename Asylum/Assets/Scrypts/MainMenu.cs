using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainmenu;
    public GameObject settings;
    public void inicio()
    {
        SceneManager.LoadScene(1);
    }

    public void Settings()

    {
        mainmenu.SetActive(false);

        settings.SetActive(true);
    }
    public void QuitGame()

    {
        Application.Quit();
    }


}