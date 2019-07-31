using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {

   public void OnMouseClick(string SceneName)
    {
        SceneManager.LoadScene(SceneName, mode: LoadSceneMode.Single); //Loads game when menu button is pressed
    }
}
