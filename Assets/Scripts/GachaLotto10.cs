using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GachaLotto10 : MonoBehaviour {
    public static bool lotto1 = false;
    Transform sitaText;
    Text text;
    int syojiCoin = 0;
    CanvasGroup canvasGroup;

    public void OnClick()
    {
        lotto1 = true;
    }

	// Use this for initialization
	void Start () {
        canvasGroup = this.gameObject.GetComponent<CanvasGroup>();
        sitaText = this.transform.Find("Text");
        text = sitaText.GetComponent<Text>();
        syojiCoin = PlayerPrefs.GetInt("Coin2");
        int kaisu = syojiCoin / 100;
        if (kaisu < 10)
        {
            if (kaisu <= 0)
            {
                text.text = 1 + "回連続";
                canvasGroup.interactable = false;
            }
            else
            {
                text.text = kaisu + "回連続";
                canvasGroup.interactable = true;
            }
        }
        else
        {
            text.text = 10 + "回連続";
            canvasGroup.interactable = true;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
