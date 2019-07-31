using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBoss : MonoBehaviour
{
    [SerializeField] public GameObject button;
    [SerializeField] public ButtonBoss otherButt;
    [SerializeField] public GameObject block;
    [SerializeField] public GameObject swordFull;
    [SerializeField] public GameObject swordHalf;
    public bool triggered = false;

    void Start()
    {
        
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (triggered == false && (collision.gameObject.CompareTag("player") || collision.gameObject.CompareTag("dead_player")))
        {
            triggered = true;
            Debug.Log("enter");
            button.GetComponent<Renderer>().enabled = false;
            swordFull.SetActive(false);
            swordHalf.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (triggered = true && (collision.gameObject.CompareTag("player") || collision.gameObject.CompareTag("dead_player")))
        {
            triggered = false;
            Debug.Log("exit");
            button.GetComponent<Renderer>().enabled = true;
            swordFull.SetActive(true);
            swordHalf.SetActive(false);
        }
    }
    private void FixedUpdate()
    {
        if (otherButt.triggered == true && this.triggered == true)
        {
            block.SetActive(false);
        }
    }
}