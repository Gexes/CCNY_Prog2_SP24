using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonHelper : MonoBehaviour
{
    //Script to change to a new scene
    public void GoToScene(string sceneName)
    {
        Debug.Log("pressed the button");
        SceneManager.LoadScene(sceneName);
    }
}
