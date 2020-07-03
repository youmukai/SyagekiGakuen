using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class EnemyController : MonoBehaviour {
    //public int damage;
    //private GameObject bullet;
    Rigidbody2D rb;
    Bullet bulletDamage;
    private GameObject enemy;
    private HpConfig hp;
    Transform target;
    public float speed = 10.0f;
    //private Vector3 vec;
    private Vector2 vec2;
    float time = 0.0f;
    SortingGroup sortingGroup;
    public GameObject effectPre;
    public int damage;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        hp = transform.GetChild(0).gameObject.GetComponent<HpConfig>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
        sortingGroup = GetComponent<SortingGroup>();
    }
	
	// Update is called once per frame
	void Update () {
        //time += Time.deltaTime;
        //Debug.Log(hp.hitPoint);
        //vec = target.transform.position + new Vector3(150, 0, 1);
        //transform.position = Vector3.MoveTowards(transform.position, vec, speed);
        if (target.position.y-1.5 > transform.position.y)
        {
            sortingGroup.sortingOrder = 11;
        }
        else
        {
            sortingGroup.sortingOrder = 9;
        }

        var distance = Vector2.Distance(transform.position, target.position);
        if (distance < 10f)
        {
            oikake();
        }
        else //if(distance>=10f)
        {
            vec2 = transform.position * 0;
            rb.velocity = vec2;
        }
        /*if (hp.hitPoint <= 0)
        {
            rb.velocity = Vector2.zero;
        }*/
    }
    public void oikake()
    {
        vec2 = ((target.transform.position + new Vector3(2, -1)) - transform.position).normalized * speed;
        rb.velocity = vec2;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Shell"))
        {
            //Debug.Log("atari");
            bulletDamage = other.GetComponent<Bullet>();
            hp.Damage(bulletDamage.damage);
            Destroy(other.gameObject);
            if (hp.hitPoint >= 0)
            {
                if (effectPre != null)
                {
                    Instantiate(
                        effectPre,
                        other.transform.position,
                        Quaternion.identity
                        );
                }
            }
        }
        //Destroy(other.gameObject);
    }
}
