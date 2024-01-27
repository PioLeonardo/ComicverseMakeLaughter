using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void ReturnToMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu"); // Replace "MainMenu" with the name of your main menu scene
    }
}
