using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject OptionsMenu;
    public void ExitGame()
    {
        Application.Quit();
    }
    public void OpenOptionMenu()
    {
        MainMenu.SetActive(false);
        OptionsMenu.SetActive(true);
    }
    public void CloseOptionMenu()
    {
        OptionsMenu.SetActive(false);
        MainMenu.SetActive(true);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Intro", LoadSceneMode.Single);
    }
    public void StartCredits()
    {
        SceneManager.LoadScene("Credits", LoadSceneMode.Single);
    }
}
