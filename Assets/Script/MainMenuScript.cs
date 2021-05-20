using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuScript : MonoBehaviour
{
    public void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public static void PlayButtonClicked()
    {
        SceneManager.LoadScene(1);
    }

    public static void ExitButtonClicked()
    {
        Application.Quit();
    }
}
