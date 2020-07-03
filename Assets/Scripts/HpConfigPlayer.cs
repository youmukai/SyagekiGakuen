using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HpConfigPlayer : MonoBehaviour {
    public int hitPoint = 100;
    Animator animator;
    Rigidbody2D rb;
    float time = 0.0f;
    public GameObject[] effectPre;
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
            animator.SetTrigger("DownAni");
            if (time > 0.5f)
            {
                rb.velocity = Vector2.zero;
            }
            //rb.velocity = Vector2.zero;
            //Destroy(gameObject);
        }
    }
    public void Yarare2()
    {
        //this.gameObject.transform.root.gameObject.SetActive(false);

        //Destroy(gameObject.transform.root.gameObject);
        if (effectPre != null)
        {
            for(int i = 0; i < effectPre.Length; i++)
            {
                Instantiate(
                effectPre[i],
                this.transform.position,
                Quaternion.identity
                );
            }
            
        }
        StartCoroutine("GameOver1");
    }
    public void Damage(int damage)
    {
        hitPoint -= damage;
    }
    IEnumerator GameOver1()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("GameOver");
    }
}
