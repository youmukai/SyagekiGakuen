using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Gacha1 : MonoBehaviour {
    private GachaTable[] gachatable = new GachaTable[2];
    private System.Random random;
    int value = 1000; // ガチャの値段
    int maxIndex = 2; // レアリティの個数(武器、能力アップアイテムで2つ)
    int countPerPack = 10; // 1回で引ける個数
    Vector3 itemPos = new Vector3(-6, 2, 0);
    Vector3 itemPos2 = new Vector3(-6, -2, 0);
    int itemSize = 5;
    List<GameObject> generatedItem = new List<GameObject>();

    int syojiCoin = 0;
    public static bool gachahiki = false;

    // Use this for initialization
    void Start () {
        for(int i = 0; i < maxIndex; i++)
        {
            gachatable[i] = Resources.Load<GachaTable>("GachaTable/" + (i + 1).ToString());
        }
        random = new System.Random((int)DateTime.Now.Ticks);

        syojiCoin = PlayerPrefs.GetInt("Coin2");
        if (GachaLotto10.lotto1 == true) // 1回だけ回すとき
        {
            if (syojiCoin < 100)
            {
                GachaLotto10.lotto1 = false;
            }
            else
            {
                countPerPack = 1;
                int hiku = syojiCoin - (100 * countPerPack);
                PlayerPrefs.SetInt("Coin2", hiku);
                gachaRen(1000);
                GachaLotto10.lotto1 = false;
                gachahiki = true;
            }
        }
        else // 10回連続回すとき
        {
            if (syojiCoin < value)
            {
                int aq = syojiCoin / 100;
                countPerPack = aq;
                //Debug.Log(countPerPack);
                int hiku1 = syojiCoin - (100 * countPerPack);
                Debug.Log(hiku1);
                PlayerPrefs.SetInt("Coin2", hiku1);
                gachaRen(1000);
                gachahiki = true;
            }
            else // 所持コインが1000より多いなら
            {
                int hiku2 = syojiCoin - (100 * countPerPack);
                //Debug.Log(hiku2);
                PlayerPrefs.SetInt("Coin2", hiku2);
                gachaRen(syojiCoin);
                gachahiki = true;
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
    public void gachaRen(int money)
    {
        List<string> resultList = new List<string>();
        int totalProbability2 = 0;
        if (money < value)
        {
            return;
        }
        for(int i = 0; i < maxIndex; i++)
        {
            totalProbability2 += gachatable[i].probability;
        }
        for(int i = 0; i < countPerPack; i++)
        {
            GameObject itemObj = getGazo(totalProbability2);
            generatedItem.Add(itemObj);
            resultList.Add(itemObj.name);
            GachaTes1.SaveList<string>("ListSaveKey1", resultList);
        }
    }
    private int getRandom(int _max) // 3%のアイテムか97%のアイテムかを決めるレアリティを抽選する
    {
        return random.Next(0, _max);
    }
    private GameObject getRandom2(List<GameObject> list2) // 同じレアリティから個別にアイテムの抽選を行う
    {
        return list2[random.Next(0, list2.Count)];
    }
    private GameObject getGazo(int allPribability2)
    {
        int randomValue2 = getRandom(allPribability2);
        int totalProbability = 0;
        for(int i = 0; i < maxIndex; i++)
        {
            totalProbability += gachatable[i].probability;
            if (generatedItem.Count <= 4) // 上段アイテム5個
            {
                for (int j = 0; j < itemSize; j++)
                {
                    if (totalProbability >= randomValue2)
                    {
                        int itemran = random.Next(0, gachatable[i].gachaItem.Count);
                        var id2 = Instantiate( 
                            gachatable[i].gachaItem[itemran] as GameObject,
                            itemPos,
                            Quaternion.identity
                            );
                        id2.name = gachatable[i].gachaItem[itemran].name;
                        itemPos.x += 3;
                        return id2;
                    }
                }
            }
            else // 下段アイテム5個
            {
                for (int j2 = 0; j2 < itemSize; j2++)
                {
                    if (totalProbability >= randomValue2)
                    {
                        int itemran = random.Next(0, gachatable[i].gachaItem.Count);
                        GameObject id2 = (GameObject)Instantiate(
                             gachatable[i].gachaItem[itemran],
                            itemPos2,
                            Quaternion.identity
                            );
                        id2.name = gachatable[i].gachaItem[itemran].name;
                        itemPos2.x += 3;
                        return id2;
                    }
                }
            }
        }
        return null;
    }
}
