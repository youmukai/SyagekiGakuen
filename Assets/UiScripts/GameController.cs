using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public HpPanel hpPanel;

    //public Girl girl;

    public Text coin;

    public Text kill;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        int getCoin;

        int getKill;

        //集めたコインの数をUIに表示
        //coin.text = "Coin:" + getCoin;

        //敵を倒した数をUIに表示
        //kill.text = "Kill:" + getKill;


        //hpPanel.UpdateHp(girl.Hp());

        //HPが０になったら、ゲームオーバー
        /*    if()
            {
                //これ以上のUpdateをやめる
                enabled = false;

                //２秒後にGameOverを呼び出す
                Invoke("GameOver", 2.0f);
            }

        //ゴールしたらClearを呼び出す
            if ()
        {
            //これ以上のUpdateを止める
            enabled = false;
            
            //coin kill 記録
            PlayerPrefs.SetInt("GetCoin",getCoin);
            PlayerPrefs.SetInt("GetKill",getKill);

            //３秒後にClearを呼び出す
            Invoke("Clear", 3.0f);
        }
        */
	}

    void GameOver()
    {
        //惨敗画面に切り替え
        SceneManager.LoadScene("GameOver");
    }

    public void Clear()
    {
        //Clear画面に切り替え
        SceneManager.LoadScene("Clear");
    }

}
