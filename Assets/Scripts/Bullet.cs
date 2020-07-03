using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public float speed = 3.0f;
    float time = 0.0f;
    Rigidbody2D rb2d;
    Transform bulletTr;
    public int damage;
    //public Vector2 forward;
    // Use this for initialization
    void Start () {
        bulletTr = this.transform;
        bulletTr.Rotate(0, 0, -90);
        rb2d = GetComponent<Rigidbody2D>();
        //transform.up.normalized * speed;
    }
	
	// Update is called once per frame
	void Update () {
        //bulletRb.velocity = new Vector2(bulletTr.position.x * speed, 69);
        //Vector3 pos = transform.position;
        time += Time.deltaTime;
        Vector2 bulletMovement = new Vector2(1, 0).normalized;
        rb2d.velocity = bulletMovement * speed;
        if (time > 1.0f)
        {
            Destroy(gameObject);
        }
    }
}
