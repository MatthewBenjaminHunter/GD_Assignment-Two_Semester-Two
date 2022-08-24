using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    public string startString = "SampleScene";
    public string menuString = "MainMenu";
    public string creditString = "Credits";
    public string final = "";
    private void Start()
    {
        


    }

    private void OnMouseDown()
    {
        if (this.gameObject.tag == "start")
        {
            final = startString;
            SceneManager.LoadScene(final);
        }

        else if (this.gameObject.tag == "menu")
        {
            final = menuString;
            SceneManager.LoadScene(final);
        }


        else if (this.gameObject.tag == "credit")
        {
            final = creditString;
            SceneManager.LoadScene(final);
        }

        else if (this.gameObject.tag == "credit")
        {
            Application.Quit();
        }
            
    }
}
