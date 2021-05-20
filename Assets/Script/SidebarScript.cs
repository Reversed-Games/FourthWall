using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SidebarScript : MonoBehaviour
{
    public GameObject console;
    public bool active = false;
    public GameObject pausegui;
    public GameObject maincamera;
    public GameObject player;


    public void ResumeGame()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        pausegui.SetActive(false);
        Time.timeScale = 1;
        Debug.Log("Game has been resumed");
        maincamera.GetComponent<FirstPersonLook>().enabled = true;
        player.GetComponent<Crouch>().enabled = true;
        player.GetComponent<Jump>().enabled = true;
    }

    public void Console()
    {
        if (active == false)
        {
            active = true;
            console.SetActive(true);
        }
        else
        {
            active = false;
            console.SetActive(false);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void GotoMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
