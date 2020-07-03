using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Animator myAnimator;
    private Vector2 velocity;
    Rigidbody2D rb;
    private float moveSpeed = 350.1f;
    private Transform player;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();//player.parent.
        myAnimator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float moveVertical = Input.GetAxis("Vertical");
        //velocity = new Vector2(0, moveVertical);
        Vector2 moveForward = Vector2.Scale(Camera.main.transform.forward, new Vector2(1, 1).normalized)*moveVertical;
        rb.velocity = new Vector2(0, moveVertical) * moveSpeed;
	}
}
