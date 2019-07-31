using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reviveWizard : MonoBehaviour {

    [SerializeField] public GameObject wizard;
    // Use this for initialization
    void Start () {
        wizard.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
