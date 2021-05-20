using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallScript : MonoBehaviour
{
    // Reversed Game Studio Presents
    private void OnCollisionEnter(Collision collision)
    {
       if(SceneManager.GetActiveScene().name == "Lvl1")
        {
            SceneManager.LoadScene(0);
            Debug.Log("Lvl1 - Wall touched");
        }
    }

    // Our first ever game
}
