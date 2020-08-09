using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinGet1 : MonoBehaviour {
    public Text coinText;
    private int coin=0;
    private int highCoin;
    private string high = "highCoin1";
	// Use this for initialization
	void Start () {
        Initialize();
	}
	
	// Update is called once per frame
	void Update () {
        coinText.text = "Coin: " + coin;
    }
    private void Initialize()
    {
        coin = 0;
        //highCoin = PlayerPrefs.GetInt(high, 0);
    }
    public void AddPoint(int point)
    {
        coin = coin + point;
    }
    public void Save()
    {
        PlayerPrefs.SetInt("Coin1", coin);//coin
        PlayerPrefs.Save();
        //Initialize();
    }
}
