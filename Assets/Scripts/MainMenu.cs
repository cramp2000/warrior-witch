using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
        private int character = 0;

    public void PlayWarrior()
    {
        character = 1;
    }

    public void PlayWitch()
    {
        character = 2;
    }

    public void PlayGame ()
    {
        if(character > 0){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + character);
        }
    }

    public void QuitGame ()
    {
        Debug.Log("Quited");
        Application.Quit();
    }
}
