using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinKeikokuSyoji : MonoBehaviour {
    Text text;
    int syojiCoin = 0;

    private void OnEnable()
    {
        text = GetComponent<Text>();
        syojiCoin = PlayerPrefs.GetInt("Coin2");
        text.text = "所持コイン: " + syojiCoin;
    }
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
