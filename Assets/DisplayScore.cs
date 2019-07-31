using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayScore : MonoBehaviour {
	public Text text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Score: " + Score.score.ToString();

		if (Score.score < 1) {
			Debug.Log("You Lose");
			SceneManager.LoadScene("Lose");
		}
	}
}
