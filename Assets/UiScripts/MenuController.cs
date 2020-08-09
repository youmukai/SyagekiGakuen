using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuController : MonoBehaviour {

    AudioSource buttonClick;

    public Text coin;
    static int nyuCoin=0; //staticはゲームが終了したら0になる
    int syojiCoin = 0;
    int kurabe = 0;

    // Use this for initialization
    void Start () {
        syojiCoin = PlayerPrefs.GetInt("Coin2");
        kurabe = PlayerPrefs.GetInt("Coin1");
        if (nyuCoin == 0)
        {
            nyuCoin = PlayerPrefs.GetInt("Coin1");
        }
        if (kurabe == nyuCoin && ClearController.kidou == false)
        {
            Debug.Log("true");
        }
        else if (Gacha1.gachahiki == true)
        {
            Debug.Log(syojiCoin);
        }
        else
        {
            nyuCoin = PlayerPrefs.GetInt("Coin1");
            Debug.Log(nyuCoin);
            syojiCoin += nyuCoin;
            PlayerPrefs.SetInt("Coin2", syojiCoin);
            Debug.Log(syojiCoin);
        }
        coin.text = "コイン: " + syojiCoin;
        Gacha1.gachahiki = false;
        buttonClick = GetComponent<AudioSource>();
        Time.timeScale = 1f;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnMapButtonClicked()
    {
        buttonClick.Play();
        Invoke("ChangeMap", 1.0f);
    }

    public void OnPlayerButtonClicked()
    {
        buttonClick.Play();
        Invoke("ChangePlayer", 1.0f);
    }

    public void OnGacyaButtonClicked()
    {
        buttonClick.Play();
        Invoke("ChangeGacya", 1.0f);
    }
    void ChangeMap()
    {
        SceneManager.LoadScene("Map");
    }
    void ChangePlayer()
    {
        SceneManager.LoadScene("Player");
    }
    void ChangeGacya()
    {
        SceneManager.LoadScene("Gacya");
    }
}
