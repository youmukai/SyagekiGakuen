using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItemChange : MonoBehaviour { 
    Anima2D.SpriteMesh[] adf;
    Anima2D.SpriteMeshInstance item1;
    //Anima2D.SpriteMesh instanceItem;
    // Player/PlayerAni/Mesh/Player_HandGun

    // Use this for initialization
    void Start () {
        item1 = GetComponent<Anima2D.SpriteMeshInstance>();
        adf = GetComponent<Anima2D.SpriteMeshAnimation>().frames;

        //item1.spriteMesh = Resources.Load<Anima2D.SpriteMesh>("SpriteMesh/PlayerItem/buki sozai1_1") as Anima2D.SpriteMesh;
        //adf[0] = Resources.Load<Anima2D.SpriteMesh>("SpriteMesh/PlayerItem/buki sozai1_1") as Anima2D.SpriteMesh;

        //instanceItem = GetComponent<Anima2D.SpriteMeshInstance>().spriteMesh;
        //for(int i = 0; i < adf.Length; i++){ Debug.Log(adf[i]); }
        //Debug.Log(instanceItem);
        //instanceItem = Resources.Load<Anima2D.SpriteMesh>("buki sozai1_1") as Anima2D.SpriteMesh; <--画像変わらない
    }

    // Update is called once per frame
    void Update () {
		
	}
}
