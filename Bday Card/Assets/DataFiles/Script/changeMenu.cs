using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class changeMenu : MonoBehaviour
{

    public AudioSource src;

    public void menucard()
    {
        SceneManager.LoadScene("MenuScene");
        
    }

    public void greetingcard()
    {
        SceneManager.LoadScene("GreetingCardScene");

    }

    public void rotatecube()
    {
        SceneManager.LoadScene("CubeScene");
    }

    public void exitapp()
    {
        Application.Quit();
        Debug.Log("Exit Button Pressed.");
    }

   /*     public void playMusic()
        {
            src.Play();
        }
        public void pauseMusic()
        {
            src.Pause();
        }
        */
}
