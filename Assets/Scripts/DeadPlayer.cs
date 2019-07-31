using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadPlayer : MonoBehaviour {

    private GameObject deadplayer;


    // Use this for initialization
    void Start () {
        deadplayer = this.gameObject;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Dead player hit object");
        if (collision.gameObject.CompareTag("spike") || collision.CompareTag("Lava"))
        {
            Destroy(deadplayer);
        }
    }
}
