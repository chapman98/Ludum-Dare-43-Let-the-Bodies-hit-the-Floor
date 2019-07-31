using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	[SerializeField]private float speed = 5.0f;
	[SerializeField]private float jump = 200.0f;

	[SerializeField]private float thrust = 600.0f;

	[SerializeField]public GameObject deadplayer;

	[SerializeField]private Rigidbody2D rb;
	private Vector3 start;

    private bool inair = false;
    public float prevpos;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		start = this.transform.position;
        prevpos = start.y;
	}

    private void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position += Vector3.left * speed * Time.deltaTime;
			transform.localScale = new Vector3 (-0.5f, 0.5f, 1f);
		}	
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position += Vector3.right * speed * Time.deltaTime;
			transform.localScale = new Vector3 (0.5f, 0.5f, 1f);
		}

		if (Input.GetKeyDown (KeyCode.UpArrow) && inair == false) {
			//transform.position += Vector3.up * jump * Time.deltaTime;
			rb.AddForce(transform.up * thrust);
            inair = true;

		}

		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			Instantiate (deadplayer, this.transform.position, Quaternion.identity);
			this.transform.position = start;
			Score.score = Score.score - 10;
		}
	}

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("map") || col.gameObject.CompareTag("dead_player"))
        {
            inair = false;
        }
    }

    void OnTriggerEnter2D (Collider2D col) 
	{
		if (col.gameObject.CompareTag("spike") || col.gameObject.CompareTag("Lava") || col.gameObject.CompareTag("Purple Lava"))
		{
			Score.score = Score.score - 10;
			Debug.Log("hit");
			this.transform.position = start;
		}
    }

	



}
