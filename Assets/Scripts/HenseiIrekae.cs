using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HenseiIrekae : MonoBehaviour {
    //Button button;
    Transform hen;
    Hensei hensei;
	// Use this for initialization
	void Start () {
        //button = this.gameObject.GetComponent<Button>();
        hen = transform.parent;
        hensei = hen.GetComponent<Hensei>();
	}
	
    public void OnClick()
    {
        hensei.player.SetActive(false);

    }

	// Update is called once per frame
	void Update () {
		
	}
}
