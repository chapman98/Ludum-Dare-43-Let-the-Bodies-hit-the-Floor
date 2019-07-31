using UnityEngine;
using System.Collections;

public class Musicplayer : MonoBehaviour {
static Musicplayer instance = null;



void awake()
{

}



	// Use this for initialization
	void Start () {
		if (instance != null)
		{
			Destroy(gameObject);
		}
		else
		{
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
