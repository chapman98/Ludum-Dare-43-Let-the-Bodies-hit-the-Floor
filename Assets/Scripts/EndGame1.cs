using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame1 : MonoBehaviour {
    [SerializeField] public ButtonBoss otherButt;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (otherButt.triggered == true)
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
