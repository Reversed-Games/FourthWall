using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ConsoleScript : MonoBehaviour
{
    public InputField consoleInput;
    public Text consoleText;
    public GameObject thirdperson;
    public GameObject firstperson;
    public void SendToConsole()
    {
        // Easter Eggs
        if (consoleInput.text == "hello")
        {
            consoleText.text = consoleText.text + "\n \n >" + consoleInput.text + "\n Hello World!";
            consoleInput.text = "";
        }
        if (consoleInput.text.StartsWith("sv_cheats") || consoleInput.text == "sv_cheats")
        {
            consoleText.text = consoleText.text + "\n \n >" + consoleInput.text + "\n lol valve ";
            consoleInput.text = "";
        }

        // Normal Commands
        if (consoleInput.text == "clear" || consoleInput.text == "cls")
        {
            consoleText.text = "";
            consoleInput.text = "";
        }

        if (consoleInput.text == "help" || consoleInput.text == "cmds")
        {
            consoleText.text = consoleText.text + "\n \n >" + consoleInput.text + "\n Help: \n clear/cls - Clears everything \n lvllist - Lists all the levels (and they're level ID) \n level - Loads in a level \n 3rdperson/thirdperson - Toggles Third Person";
            consoleInput.text = "";
        }

        // User/Admin Based Commands
        if(consoleInput.text == "lvllist")
        {
            consoleText.text = consoleText.text + "\n \n >" + consoleInput.text + "\n lvl1 - Level One \n lvl2 - Level Two \n lvl3 - Level Three \n lvl4 - Level Four \n secret - Secret Level";
            consoleInput.text = "";
        }

        if (consoleInput.text == "level")
        {
            consoleText.text = consoleText.text + "\n \n >" + consoleInput.text + "\n Usage: level (lvlID) [You can find a level ID with lvllist]";
            consoleInput.text = "";
        }

        if (consoleInput.text == "level lvl1")
        {
            SceneManager.LoadScene("Lvl1");
        }

        if (consoleInput.text == "level secret")
        {
            SceneManager.LoadScene("Secret");
        }

        if (consoleInput.text == "level lvl2")
        {
            SceneManager.LoadScene("Lvl2");
        }

        if (consoleInput.text == "level lvl3")
        {
            SceneManager.LoadScene("Lvl3");
        }

        if (consoleInput.text == "level lvl4")
        {
            SceneManager.LoadScene("Lvl4");
        }

        if (consoleInput.text == "3rdperson" || consoleInput.text == "thirdperson")
        {
            consoleText.text = consoleText.text + "\n \n >" + consoleInput.text + "\n Usage - thirdperson/3rdperson (true/false)";
            consoleInput.text = "";
        }

        if (consoleInput.text == "3rdperson true" || consoleInput.text == "thirdperson true")
        {
            consoleText.text = consoleText.text + "\n \n >" + consoleInput.text + "\n Set Third-Person to true";
            consoleInput.text = "";
            thirdperson.SetActive(true);
            firstperson.SetActive(false);
        }

        if (consoleInput.text == "3rdperson false" || consoleInput.text == "thirdperson false")
        {
            consoleText.text = consoleText.text + "\n \n >" + consoleInput.text + "\n Set Third-Person to false";
            consoleInput.text = "";
            thirdperson.SetActive(false);
            firstperson.SetActive(true);
        }

    }

}