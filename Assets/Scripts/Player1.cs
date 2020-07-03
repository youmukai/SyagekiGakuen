using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player1 : MonoBehaviour {
    Animator animator;
    int handgunAttackLayer;
    int handgunRunAttackLayer;
    int rifleAttackLayer;
    int rifleRunLayer;
    float riAtWeight=1;
    float haAtWeight = 1;
    bool gunOne = false;
    public float moveSpeed = 350.1f;
    GameObject player;
    Rigidbody2D rb;
    public float seigenMaix = -48.0f;
    public float seigenPrax = 48.0f;
    public float seigenMaiy = -48.0f;
    public float seigenPray = 48.0f;
    bool goalTyaku = false;
    public GameObject goalUI;
    private HpConfigPlayer hp;
    public GameObject effectPre;
    private float timeleft;
    bool beingWait = false;
    EnemyController ecDamege;
    public GameObject coinGet;
    /*enum State{
        HandgunState,
        RifleState
    }
    State state;*/

    // Use this for initialization
    void Start () {
        
        animator = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
        rb = player.GetComponent<Rigidbody2D>();
        handgunAttackLayer = animator.GetLayerIndex("HandgunAttack Layer");
        handgunRunAttackLayer = animator.GetLayerIndex("HandgunRunAttack Layer");
        rifleAttackLayer= animator.GetLayerIndex("RifleAttack Layer");
        rifleRunLayer = animator.GetLayerIndex("Rifle Layer");
        goalUI.SetActive(false);
        hp = GetComponent<HpConfigPlayer>();
        Time.timeScale = 1f;
        //Debug.Log("Base: " + animator.GetLayerIndex("Base Layer"));
    }
	
	// Update is called once per frame
	void Update () {
        float moveVertical = Input.GetAxisRaw("Vertical");
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        if (!goalTyaku)
        {
            rb.velocity = new Vector2(moveHorizontal, moveVertical) * moveSpeed;
        }
        else
        {
            rb.velocity = Vector2.zero;
            animator.SetTrigger("AttackAni");
        }

        //animator.SetBool("RunAni", true);
        if (Input.GetAxisRaw("Vertical")!=0 || Input.GetAxisRaw("Horizontal")!=0)//アニメ遷移
        {
            animator.SetBool("RunAni", true);
        }
        else
        {
            animator.SetBool("RunAni", false);
        }

        SeigenArea();

        if (Input.GetKey(KeyCode.Alpha1))// 拳銃装備
        {
            animator.SetLayerWeight(rifleRunLayer, 0);
        }
        if (Input.GetKey(KeyCode.Alpha2))// ライフル装備
        {
            animator.SetLayerWeight(rifleRunLayer, 1);
        }
        Attack();
        
    }
    public void Attack()
    {
        if (Input.GetKey(KeyCode.Z) && !gunOne)// 拳銃攻撃
        {
            gunOne = true;
            animator.SetLayerWeight(rifleRunLayer, 0);
            animator.SetLayerWeight(handgunRunAttackLayer, 0);
            animator.SetLayerWeight(handgunAttackLayer, 1);
            if (!animator.GetCurrentAnimatorStateInfo(0).IsName("RunAnimation"))
            {
                animator.SetTrigger("AttackAni");
            }
            else if (!animator.GetCurrentAnimatorStateInfo(0).IsName("IdleAnimation"))
            {
                animator.SetLayerWeight(handgunAttackLayer, 0);
                animator.SetLayerWeight(handgunRunAttackLayer, 1);
                animator.SetTrigger("AttackRunAni");
            }

        }
        else if (Input.GetKeyUp(KeyCode.Z))//haAtWeight==1 && 
        {
            gunOne = false;
        }

        if (Input.GetKey(KeyCode.X))// ライフル攻撃
        {
            animator.SetLayerWeight(handgunRunAttackLayer, 0);
            animator.SetLayerWeight(rifleRunLayer, 1);
            animator.SetLayerWeight(rifleAttackLayer, 1);
        }
        else if (Input.GetKeyUp(KeyCode.X))//riAtWeight==1 && 
        {
            animator.SetLayerWeight(rifleRunLayer, 1);
            animator.SetLayerWeight(rifleAttackLayer, 0);
        }
    }
    void IveAttack() // animeIvent
    {
        animator.SetLayerWeight(handgunAttackLayer, 0);
        animator.SetLayerWeight(handgunRunAttackLayer, 0);
    }
    public void SeigenArea()
    {
        player.transform.position = new Vector3
            (Mathf.Clamp(player.transform.position.x, seigenMaix, seigenPrax), Mathf.Clamp(player.transform.position.y, seigenMaiy, seigenPray), player.transform.position.z);
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        
        if (other.CompareTag("Goal"))
        {
            //PlayerPrefs.SetInt("stage1Clear", 1);
            CoinGet1 coinGet1 = coinGet.GetComponent<CoinGet1>();
            coinGet1.Save();
        }
        if (other.CompareTag("Goal"))
        {
            Debug.Log("goal1");
            goalUI.SetActive(!goalUI.activeSelf);
            goalTyaku = true;
            //animator.SetTrigger("AttackAni");
            //player.transform.position = other.transform.position;
            //Time.timeScale = 0f;
            //SceneManager.LoadScene("Menu");
            StartCoroutine("HyoujiGoal");
        }

        if (other.CompareTag("Enemy"))
        {
            //Debug.Log("atari");
            ecDamege = other.GetComponent<EnemyController>();
            if (!beingWait)
            {
                StartCoroutine("EnemeyAttack");
            }
            Debug.Log(hp.hitPoint);
            /*if (hp.hitPoint >= 0)
            {
                if (effectPre != null)
                {
                    Instantiate(
                        effectPre,
                        other.transform.position,
                        Quaternion.identity
                        );
                }
            }*/
        }
    }
    IEnumerator HyoujiGoal()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Clear");
    }
    IEnumerator EnemeyAttack()
    {
        beingWait = true;
        hp.Damage(ecDamege.damage);
        if (hp.hitPoint >= 0)
        {
            if (effectPre != null)
            {
                Instantiate(
                    effectPre,
                    this.transform.position,
                    Quaternion.identity
                    );
            }
        }
        yield return new WaitForSeconds(1.5f);
        beingWait = false;
    }
}
