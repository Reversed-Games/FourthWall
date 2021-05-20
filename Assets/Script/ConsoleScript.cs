using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ConsoleScript : MonoBehaviour
{
    public InputField consoleInput;
    public Text consoleText;
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
            consoleText.text = consoleText.text + "\n \n >" + consoleInput.text + "\n Help: \n clear/cls - Clears everything \n lvllist - Lists all the levels (and they're level ID) \n level - Loads in a level";
            consoleInput.text = "";
        }

        // User/Admin Based Commands
        if(consoleInput.text == "lvllist")
        {
            consoleText.text = consoleText.text + "\n \n >" + consoleInput.text + "\n lvl1 - Level One \n secret - Secret Level";
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

    }

}