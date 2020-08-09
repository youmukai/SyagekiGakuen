using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClearController : MonoBehaviour {
    public Text coin;
    public Text kill;
    public static bool kidou = false;

	// Use this for initialization
	void Start () {
        //Coin Kill　記録を表示
        coin.text = "Coin:" + PlayerPrefs.GetInt("Coin1");
        //kill.text = "Kill:" + PlayerPrefs.GetInt("GetKill");
        kidou = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnHomeButtonClicked()
    {
        SceneManager.LoadScene("Home");
    }
}
