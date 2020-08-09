using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hensei : MonoBehaviour {
    public GameObject player;
    Transform playerAni;
    Animator animator;
    int rifleRunLayer;
    int handgunLayer;
    //public bool playerAc { get; set; }
    private void OnEnable()
    {
        player.SetActive(true);
        //playerAc = true;
    }
    private void OnDisable()
    {
        /*if (playerAc == true)
        {
            player.SetActive(false);
        }*/
    }

    public void OnHandgunClick()
    {
        animator.SetLayerWeight(rifleRunLayer, 0);
        animator.SetLayerWeight(handgunLayer, 1);
    }
    public void OnRifleClick()
    {
        animator.SetLayerWeight(rifleRunLayer, 1);
        animator.SetLayerWeight(handgunLayer, 0);
    }

    // Use this for initialization
    void Start () {
        playerAni = player.transform.Find("PlayerAni");
        animator = playerAni.GetComponent<Animator>();
        rifleRunLayer = animator.GetLayerIndex("Rifle Layer");
        handgunLayer = animator.GetLayerIndex("Handgun Layer");
    }
	
	// Update is called once per frame
	void Update () {

	}
}
