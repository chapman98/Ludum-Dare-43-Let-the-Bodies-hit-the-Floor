using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EasterSceneChange : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {

        // Use a coroutine to load the Scene in the background
        StartCoroutine(LoadYourAsyncScene());
        Debug.Log("Door collide");
        Score.score = Score.score + 100;
    }

    public void OnBecameActive()
    {
        Debug.Log("Cut scene end");
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "End Game")
        {
            StartCoroutine(LoadYourAsyncScene());
        }

    }

    IEnumerator LoadYourAsyncScene()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.
        Scene curScene = SceneManager.GetActiveScene();
        AsyncOperation asyncLoad;
        Debug.Log(curScene.name);
        if (curScene.name == "Level 4"){
            asyncLoad = SceneManager.LoadSceneAsync("Level 9");
            while (!asyncLoad.isDone)
            {
                yield return null;
            }
        } else if (curScene.name == "Level 9")  {
            Debug.Log("Level 9 to 5, what a way to kill a body");
            asyncLoad = SceneManager.LoadSceneAsync("Level 5");
            while (!asyncLoad.isDone)
            {
                yield return null;
            }
        }
        else if (curScene.name == "End Game")
        {
            Debug.Log("Ending the game");
            asyncLoad = SceneManager.LoadSceneAsync("Complete Menu");
            while (!asyncLoad.isDone)
            {
                yield return null;
            }
        }
        // Wait until the asynchronous scene fully loads


    }
}