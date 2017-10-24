using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour
{

    public void LoadLevel(string levelName)
    {
        print("Loading level " + levelName);
        //loads the scene named levelName
        SceneManager.LoadScene(levelName);
    }

    public void exit()
    {
        print("Exiting the game");
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
