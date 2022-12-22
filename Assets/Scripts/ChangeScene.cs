using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        if(sceneName == "Quit")
        {
            Application.Quit();
        }
        SceneManager.LoadScene(sceneName);
    }

    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void LoadGame()
    {
        
        SceneManager.LoadScene(1);
    }
}
