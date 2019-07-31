using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        // Use a coroutine to load the Scene in the background
        StartCoroutine(LoadYourAsyncScene());
        Debug.Log("Door collide");
		Score.score = Score.score + 100;
    }
    public void OnBecameVisible()
    {
        Debug.Log("Cut scene end");
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "CutScene" || scene.name == "End Game") {
            Debug.Log("After cut scene");
            StartCoroutine(LoadYourAsyncScene());
        }
        
    }

    IEnumerator LoadYourAsyncScene()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log(scene.name + scene.buildIndex + 1);
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(scene.buildIndex + 1);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}