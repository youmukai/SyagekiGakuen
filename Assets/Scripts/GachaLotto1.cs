using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GachaLotto1 : MonoBehaviour {
    Transform husokuText;
    Text text;
    int syojiCoin = 0;
    CanvasGroup canvasGroup;

	// Use this for initialization
	void Start () {
        canvasGroup = this.gameObject.GetComponent<CanvasGroup>();
        husokuText = this.transform.Find("HusokuText");
        text = husokuText.GetComponent<Text>();
        syojiCoin = PlayerPrefs.GetInt("Coin2");
        int kaisu = syojiCoin / 100;
        if (kaisu <= 0)
        {
            canvasGroup.interactable = false;
            husokuText.gameObject.SetActive(true);
        }
        else
        {
            canvasGroup.interactable = true;
            husokuText.gameObject.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
