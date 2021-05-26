using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerScript : MonoBehaviour
{
    public GameObject Trigger;
    public GameObject moveablecubeLVL5;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player" && Trigger.tag == "Trigger" && Trigger.name == "Trigger1" && SceneManager.GetActiveScene().name == "Lvl5")
        {
            collision.collider.transform.position = new Vector3(-1.54f, 0.5f, -4.004452f);
            Debug.Log("Player hit Trigger1 in Lvl5");
            Trigger.GetComponent<BoxCollider>().enabled = false;
        }

        if (collision.collider.tag == "Player" && Trigger.tag == "Trigger" && Trigger.name == "Trigger2" && SceneManager.GetActiveScene().name == "Lvl5")
        {
            moveablecubeLVL5.transform.position = new Vector3(moveablecubeLVL5.transform.position.x, moveablecubeLVL5.transform.position.y + 25.27f, moveablecubeLVL5.transform.position.z);
            Debug.Log("Player hit Trigger2 in Lvl5");
            Trigger.GetComponent<BoxCollider>().enabled = false;

        }

        if (collision.collider.tag == "Player" && Trigger.tag == "Trigger" && Trigger.name == "Trigger3" && SceneManager.GetActiveScene().name == "Lvl5")
        {
            SceneManager.LoadScene(0);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
