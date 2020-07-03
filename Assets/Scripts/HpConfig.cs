using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpConfig : MonoBehaviour {
    public int hitPoint = 100;
    Animator animator;
    Rigidbody2D rb;
    float time = 0.0f;
    public GameObject effectPre;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        rb = transform.root.gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (hitPoint <= 0)
        {
            time += Time.deltaTime;
            animator.SetTrigger("DownAniTrigger");
            if (time > 0.5f)
            {
                rb.velocity = Vector2.zero;
            }
            //rb.velocity = Vector2.zero;
            //Destroy(gameObject);
        }
    }
    public void Yarare()
    {
        Destroy(gameObject.transform.root.gameObject);
        if (effectPre != null)
        {
            Instantiate(
                effectPre,
                this.transform.position,
                Quaternion.identity
                );
        }

    }
    public void Damage(int damage)
    {
        hitPoint -= damage;
    }
}
