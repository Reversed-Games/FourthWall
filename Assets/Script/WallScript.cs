using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
       if(SceneManager.GetActiveScene().name == "Lvl1")
        {
            SceneManager.LoadScene("Lvl2");
            Debug.Log("Lvl1 - Wall touched");
        }
        if (SceneManager.GetActiveScene().name == "Lvl2")
        {
            SceneManager.LoadScene("Lvl3");
            Debug.Log("Lvl2 - Wall touched");
        }
        if (SceneManager.GetActiveScene().name == "Lvl3")
        {
            SceneManager.LoadScene("Lvl4");
            Debug.Log("Lvl3 - Wall touched");
        }

        if (SceneManager.GetActiveScene().name == "Lvl4")
        {
            SceneManager.LoadScene(0);
            Debug.Log("Lvl4 - Wall touched");
        }

        if (SceneManager.GetActiveScene().name == "Secret")
        {
            SceneManager.LoadScene(0);
            Debug.Log("Secret - Wall touched");
        }
    }
}
