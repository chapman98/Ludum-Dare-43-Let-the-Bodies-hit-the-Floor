using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSpike : MonoBehaviour {
	[SerializeField]public GameObject newspike;
	[SerializeField]public GameObject spike;
	private Vector3 pos;
	// Use this for initialization
	void Start () {
		pos = spike.transform.position;
	}
	
	void OnTriggerEnter2D (Collider2D col) 
	{
        if (col.gameObject.CompareTag("player"))
        {
            Debug.Log("hit2");
            Destroy(spike);
            Instantiate(newspike, pos, Quaternion.identity);
        } else if (col.gameObject.CompareTag("dead_player")) {
            Debug.Log("hit2");
            Destroy(spike);
            Instantiate(newspike, pos, Quaternion.identity);
        }
}

}
