using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Secret : MonoBehaviour
{
    // Reversed Game Studio Presents
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("Secret");
    }

    // Our first ever game
}
