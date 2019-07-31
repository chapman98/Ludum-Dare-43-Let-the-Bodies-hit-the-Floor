using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {
    [SerializeField] public GameObject button;
    [SerializeField] public GameObject door;
    private Vector3 doorpos;
    private bool triggered = false;

    void Start()
    {
        doorpos = door.transform.position;
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (triggered == false && (collision.gameObject.CompareTag("player") || collision.gameObject.CompareTag("dead_player"))) {
            triggered = true;
            Debug.Log("enter");
            button.GetComponent<Renderer>().enabled = false;
            door.SetActive(false);
        }
    }

    void OnTriggerExit2D(Collider2D collision) {
        if (triggered = true && (collision.gameObject.CompareTag("player") || collision.gameObject.CompareTag("dead_player"))) {
            triggered = false;
            Debug.Log("exit");
            button.GetComponent<Renderer>().enabled = true;
            door.SetActive(true);
        }
    }
}