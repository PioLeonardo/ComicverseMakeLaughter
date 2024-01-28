using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Credit : MonoBehaviour
{
    // Start is called before the first frame update
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu"); // Replace "MainMenu" with the name of your main menu scene
    }
}
