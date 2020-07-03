using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpPanel : MonoBehaviour {

    public GameObject[] icons;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //HPに応じてアイコンを出し続ける
    public void UpdateHp(int hp)
    {
        for(int i = 0; i < icons.Length; i++)
        {
            if (i < hp) icons[i].SetActive(true);
            else icons[i].SetActive(false);
        }
    }

}
