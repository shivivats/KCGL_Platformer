using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneManager : MonoBehaviour
{
    public void RetryGame()
    {
        // load the main scene
        SceneManager.LoadScene("Main");
    }

    public void ExitGame()
    {
        // quit the game
        Application.Quit();
    }
}
