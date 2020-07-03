using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuController : MonoBehaviour {

    AudioSource buttonClick;
    public Text coin;

    // Use this for initialization
    void Start () {
        int a = PlayerPrefs.GetInt("Coin1");
        PlayerPrefs.SetInt("AwaseCoin", a);
        int awase = PlayerPrefs.GetInt("AwaseCoin") + PlayerPrefs.GetInt("Coin1");
        coin.text = awase.ToString();
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
