using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        //Loads the game scene
        SceneManager.LoadScene(1);
    }

    public void CheckScore()
    {
        //Loads the check score scene
        SceneManager.LoadScene(2);
    }
}
